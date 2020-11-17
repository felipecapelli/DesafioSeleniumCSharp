using ClosedXML.Excel;
using Felipe.Desafio.AnalistaDeTestes.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Felipe.Desafio.AnalistaDeTestes.Tests
{
    [Collection("Chrome Driver")]
    public class AoBuscarProdutos
    {
        private IWebDriver driver;
        //private ExcelHelper ExcelHelper = new ExcelHelper();
        private static IList<Produto> Produtos = new List<Produto>();


        //SetUP
        public AoBuscarProdutos()
        {
            driver = new ChromeDriver(TestHelper.PastaDoExecutavel);
            //ExcelHelper.ConfiguraPlanilha();
        }

        //TearDown
        public void TearDown()
        {
            driver.Quit();
        }

        [Fact]
        public void DadoProdutoSamsungBuscaDeveBuscarDadosDoProduto()
        {
            //ACESSA O SITE
            driver.Navigate().GoToUrl("https://www.americanas.com.br");
            driver.Manage().Window.Maximize();

            //FAZ A PESQUISA
            var inputPesquisa = driver.FindElement(By.Id("h_search-input"));
            var buttonPesquisa = driver.FindElement(By.Id("h_search-btn"));
            inputPesquisa.SendKeys("Samsung Galaxy A70");
            buttonPesquisa.Click();

            //FECHA O DIÁLOGO DOS COOCKIES
            Thread.Sleep(4000);
            IWebElement buttonCoockies = driver.FindElement(By.XPath("/html/body/footer/div[4]/button"));
            buttonCoockies.Click();

            //SELECIONA O PRODUTO
            IWebElement buttonProduto = driver.FindElement(By.XPath("/html/body/div/div/div/div[3]/div[2]/div[2]"));
            buttonProduto.Click();

            //COLETA AS INFORMAÇÕES DO PRODUTO
            Produto produto = new Produto();
            produto.Loja = driver.FindElement(By.Id("brd-title")).Text;
            produto.Nome = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[2]/span")).Text;
            produto.Preco = driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div[2]/div[1]/div[2]/div")).Text;
            produto.Cashbach = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/p/span")).Text;

            Produtos.Add(produto);

            //ExcelHelper.InserirDados(loja, nome, preco, cashbach);

            Assert.True(true);

            TearDown();


            ExcelHelper.SalvarPlanilha(Produtos);
            //ExcelHelper.SalvarPlanilha();
        }

        [Fact]
        public void DadoProdutoMotorolaBuscaDeveBuscarDadosDoProduto()
        {
            //ACESSA O SITE
            driver.Navigate().GoToUrl("https://www.americanas.com.br");
            driver.Manage().Window.Maximize();

            //FAZ A PESQUISA
            var inputPesquisa = driver.FindElement(By.Id("h_search-input"));
            var buttonPesquisa = driver.FindElement(By.Id("h_search-btn"));
            inputPesquisa.SendKeys("Motorola One Vision");
            buttonPesquisa.Click();

            //FECHA O DIÁLOGO DOS COOCKIES
            Thread.Sleep(4000);
            IWebElement buttonCoockies = driver.FindElement(By.XPath("/html/body/footer/div[4]/button"));
            buttonCoockies.Click();

            //SELECIONA O PRODUTO
            IWebElement buttonProduto = driver.FindElement(By.XPath("/html/body/div/div/div/div[3]/div[2]/div[1]"));
            buttonProduto.Click();

            //COLETA AS INFORMAÇÕES DO PRODUTO
            Produto produto = new Produto();
            produto.Loja = driver.FindElement(By.Id("brd-title")).Text;
            produto.Nome = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[2]/span")).Text;
            produto.Preco = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/div[1]/div")).Text;
            produto.Cashbach = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/p/span")).Text;

            Produtos.Add(produto);
            //ExcelHelper.InserirDados(loja, nome, preco, cashbach);

            Assert.True(true);

            TearDown();
        }

        [Fact]
        public void DadoProdutoXiaomiBuscaDeveBuscarDadosDoProduto()
        {
            //ACESSA O SITE
            driver.Navigate().GoToUrl("https://www.americanas.com.br");
            driver.Manage().Window.Maximize();

            //FAZ A PESQUISA
            var inputPesquisa = driver.FindElement(By.Id("h_search-input"));
            var buttonPesquisa = driver.FindElement(By.Id("h_search-btn"));
            inputPesquisa.SendKeys("Smartphone Xiaomi Redmi Note 7");
            buttonPesquisa.Click();

            //FECHA O DIÁLOGO DOS COOCKIES
            Thread.Sleep(4000);
            IWebElement buttonCoockies = driver.FindElement(By.XPath("/html/body/footer/div[4]/button"));
            buttonCoockies.Click();

            //SELECIONA O PRODUTO
            IWebElement buttonProduto = driver.FindElement(By.XPath("/html/body/div/div/div/div[3]/div[3]/div[1]"));
            buttonProduto.Click();

            //COLETA AS INFORMAÇÕES DO PRODUTO
            Produto produto = new Produto();
            produto.Loja = driver.FindElement(By.Id("brd-title")).Text;
            produto.Nome = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[2]/span")).Text;
            produto.Preco = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/div[1]/div")).Text;
            produto.Cashbach = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[1]/p/span")).Text;


            Produtos.Add(produto);
            //ExcelHelper.InserirDados(loja, nome, preco, cashbach);

            Assert.True(true);

            TearDown();
        }

    }
}
