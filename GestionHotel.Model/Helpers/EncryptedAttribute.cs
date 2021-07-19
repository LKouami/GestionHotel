using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Model.Helpers
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class EncryptedAttribute : Attribute
    { }
}
