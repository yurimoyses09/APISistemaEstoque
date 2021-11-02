using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Componentes.Sistema.Estoque.Enums
{
    public static class Enums_SistemaEstoque
    {
        public enum LogsSistemaEstoque
        {
            // Acessos
            [Description("Acessando API InsereUsuario")]
            acesssandoApiInsereUsuario,

            // Objetos Nulos
            [Description("Os dados de Usuario sao nulos")]
            ValorNuloUsuario,

            [Description("Execucao finalizada")]
            FimExecucao
        }

        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                    .GetMember(enumValue.ToString()).First().GetCustomAttribute<DescriptionAttribute>()?.Description ?? string.Empty;
        }
    }
}
