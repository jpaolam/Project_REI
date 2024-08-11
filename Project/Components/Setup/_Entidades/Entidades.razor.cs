using Microsoft.AspNetCore.Components;
using ProjectApplication.Setup.Dto;
using ProjectApplication.Setup.Interfaces;
using ProjectApplication.Setup.Services;
using ProjectDomain.Setup.Entities;
using Radzen;

namespace Project.Components.Setup._Entidades
{
	public partial class Entidades : ComponentBase
	{
		[Parameter]
		public int EntidadId { get; set; }

		[Inject]
		public required IEntidadService EntidadService { get; set; }//inyectamos la interfaz de servicio

		[Inject]
		public required NotificationService notificationService { get; set; }//inyectamos la clase de servicio

		//INSTANCIAMOS EL DTO DE ENTIDAD
		private EntidadDto entidadDto = new EntidadDto(); //esta variable es la que usaremos para conseguir los datos

		private string[]? Errors = [];

		private bool DisabledBtn = false;

        protected override void OnInitialized()
        {
            //entidadDto = new EntidadDto
            //{
            //    RazonSocial = "Valor Inicial",
            //    Documento = 12345,
            //    TipoEntidad = 1
            //};
        }

        private async Task HandleValidSubmit()
		{
			Console.WriteLine("Entro a HandleValidSubmit");
			//Imprimir los datos de dto
			var result = await EntidadService.AddAsync(entidadDto);
			Console.WriteLine($"Razon Social: {entidadDto.RazonSocial}");
			Console.WriteLine($"Documento: {entidadDto.Documento}");
			Console.WriteLine($"Tipo de Entidad: {entidadDto.TipoEntidad}");
			NotificationMessage message;

			if (result.IsSuccess)
			{
				message =
					new NotificationMessage
					{
						Severity = NotificationSeverity.Success,
						Summary = "Se guardo con exito la cuenta en el manual",
						Duration = 2000
					};
				Errors = [];
				entidadDto = new EntidadDto();
			}
			else
			{
				message =
					new NotificationMessage
					{
						Severity = NotificationSeverity.Error,
						Summary = "Ocurrió un error al guardar la cuenta en el manual",
						Duration = 2000
					};

				Errors = result.Errors;
			}

			notificationService.Notify(message);
		}

	}
}
