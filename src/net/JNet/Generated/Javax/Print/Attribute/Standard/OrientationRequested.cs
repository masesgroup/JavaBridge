/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region OrientationRequested
    public partial class OrientationRequested
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.OrientationRequested"/> to <see cref="Javax.Print.Attribute.DocAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.DocAttribute(Javax.Print.Attribute.Standard.OrientationRequested t) => t.Cast<Javax.Print.Attribute.DocAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.OrientationRequested"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.OrientationRequested t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.OrientationRequested"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.OrientationRequested t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#LANDSCAPE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.OrientationRequested LANDSCAPE { get { if (!_LANDSCAPEReady) { _LANDSCAPEContent = SGetField<Javax.Print.Attribute.Standard.OrientationRequested>(LocalBridgeClazz, "LANDSCAPE"); _LANDSCAPEReady = true; } return _LANDSCAPEContent; } }
        private static Javax.Print.Attribute.Standard.OrientationRequested _LANDSCAPEContent = default;
        private static bool _LANDSCAPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#PORTRAIT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.OrientationRequested PORTRAIT { get { if (!_PORTRAITReady) { _PORTRAITContent = SGetField<Javax.Print.Attribute.Standard.OrientationRequested>(LocalBridgeClazz, "PORTRAIT"); _PORTRAITReady = true; } return _PORTRAITContent; } }
        private static Javax.Print.Attribute.Standard.OrientationRequested _PORTRAITContent = default;
        private static bool _PORTRAITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#REVERSE_LANDSCAPE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.OrientationRequested REVERSE_LANDSCAPE { get { if (!_REVERSE_LANDSCAPEReady) { _REVERSE_LANDSCAPEContent = SGetField<Javax.Print.Attribute.Standard.OrientationRequested>(LocalBridgeClazz, "REVERSE_LANDSCAPE"); _REVERSE_LANDSCAPEReady = true; } return _REVERSE_LANDSCAPEContent; } }
        private static Javax.Print.Attribute.Standard.OrientationRequested _REVERSE_LANDSCAPEContent = default;
        private static bool _REVERSE_LANDSCAPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#REVERSE_PORTRAIT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.OrientationRequested REVERSE_PORTRAIT { get { if (!_REVERSE_PORTRAITReady) { _REVERSE_PORTRAITContent = SGetField<Javax.Print.Attribute.Standard.OrientationRequested>(LocalBridgeClazz, "REVERSE_PORTRAIT"); _REVERSE_PORTRAITReady = true; } return _REVERSE_PORTRAITContent; } }
        private static Javax.Print.Attribute.Standard.OrientationRequested _REVERSE_PORTRAITContent = default;
        private static bool _REVERSE_PORTRAITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/OrientationRequested.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}