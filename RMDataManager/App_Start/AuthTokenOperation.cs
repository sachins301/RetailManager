using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Swashbuckle.Swagger;
using System.Web.Http.Description;

namespace RMDataManager.App_Start
{
    public class AuthTokenOperation : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths.Add("/token", new PathItem
            {
                post = new Operation
                {
                    tags = new List<String> { "Auth" },
                    consumes = new List<String>
                    {
                  "application/x-www-form-urlencode"
                    },
                    parameters = new List<Parameter> {
                        new Parameter {
                            type = "String",
                            name = "grant_type",
                            required = true,
                            @in = "formData",
                            @default = "password"
                        },
                        new Parameter {
                            type = "String",
                            name = "username",
                            required = false,
                            @in = "formData"
                        },
                        new Parameter {
                            type = "String",
                            name = "password",
                            required = false,
                            @in = "formData"
                        }
                    }
                }

            });
        }
    }

}