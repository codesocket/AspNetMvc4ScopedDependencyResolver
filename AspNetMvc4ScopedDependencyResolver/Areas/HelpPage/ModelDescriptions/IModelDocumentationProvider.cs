using System;
using System.Reflection;

namespace AspNetMvc4ScopedDependencyResolver.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}