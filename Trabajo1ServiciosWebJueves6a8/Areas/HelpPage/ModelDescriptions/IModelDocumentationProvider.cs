using System;
using System.Reflection;

namespace Trabajo1ServiciosWebJueves6a8.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}