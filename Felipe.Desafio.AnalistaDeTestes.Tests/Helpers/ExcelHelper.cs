using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Felipe.Desafio.AnalistaDeTestes.Tests.Helpers
{
    public static class ExcelHelper
    {
        public static void SalvarPlanilha(IList<Produto> produtos)
        {
            var Workbook = new XLWorkbook();

            var Worksheet = Workbook.Worksheets.Add("Desafio");
            Worksheet.Cell("A1").Value = "Loja";
            Worksheet.Cell("B1").Value = "Nome";
            Worksheet.Cell("C1").Value = "Valor";
            Worksheet.Cell("D1").Value = "CashBack";

            var linhaAtual = 2;
            foreach (var produto in produtos)
            {
                Worksheet.Cell("A" + linhaAtual).Value = produto.Loja;
                Worksheet.Cell("B" + linhaAtual).Value = produto.Nome;
                Worksheet.Cell("C" + linhaAtual).Value = produto.Preco;
                Worksheet.Cell("D" + linhaAtual).Value = produto.Cashbach;
                linhaAtual++;
            }

            Workbook.SaveAs("./../../../../Desafio.xlsx");
        }

    }
}
