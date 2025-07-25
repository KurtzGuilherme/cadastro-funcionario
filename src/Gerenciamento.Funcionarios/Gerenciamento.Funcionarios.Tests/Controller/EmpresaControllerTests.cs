using Gerenciamento.Funcionarios.Api.Controllers;
using Gerenciamento.Funcionarios.Aplicacao.Interfaces;
using Gerenciamento.Funcionarios.Aplicacao.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Moq;
using Moq.AutoMock;

namespace Gerenciamento.Funcionarios.Tests.Controller;
public class EmpresaControllerTests
{
    private readonly AutoMocker _autoMock;
    private readonly Mock<IEmpresaServico> _mockEmpresaServico;

    public EmpresaControllerTests()
    {
        _autoMock = new AutoMocker();
        _mockEmpresaServico = new Mock<IEmpresaServico>();
    }

    [Fact]
    public async Task GetEmpresa_EmpresaResponseIsNull_ShouldNotFound()
    {
        //Arrange
        var controller = CreateController();
        var idFake = Guid.NewGuid();

        _autoMock.GetMock<IEmpresaServico>()
            .Setup(m => m.FindAsync(It.IsAny<Guid>()))
            .ReturnsAsync((EmpresaResponse)null);

        //Act
        var response = await controller.GetEmpresa(idFake);

        //Assert
        Assert.Multiple(() =>
        {
            var result = Assert.IsType<NoContentResult>(response);
            Assert.Equal(StatusCodes.Status204NoContent, result.StatusCode);
        });
    }


    private EmpresaController CreateController()
        => new EmpresaController(_mockEmpresaServico.Object);
}
