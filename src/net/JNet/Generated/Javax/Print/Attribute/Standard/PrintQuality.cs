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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PrintQuality
    public partial class PrintQuality
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrintQuality"/> to <see cref="Javax.Print.Attribute.DocAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.DocAttribute(Javax.Print.Attribute.Standard.PrintQuality t) => t.Cast<Javax.Print.Attribute.DocAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrintQuality"/> to <see cref="Javax.Print.Attribute.PrintRequestAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintRequestAttribute(Javax.Print.Attribute.Standard.PrintQuality t) => t.Cast<Javax.Print.Attribute.PrintRequestAttribute>();
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrintQuality"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.PrintQuality t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrintQuality.html#DRAFT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrintQuality DRAFT { get { if (!_DRAFTReady) { _DRAFTContent = SGetField<Javax.Print.Attribute.Standard.PrintQuality>(LocalBridgeClazz, "DRAFT"); _DRAFTReady = true; } return _DRAFTContent; } }
        private static Javax.Print.Attribute.Standard.PrintQuality _DRAFTContent = default;
        private static bool _DRAFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrintQuality.html#HIGH"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrintQuality HIGH { get { if (!_HIGHReady) { _HIGHContent = SGetField<Javax.Print.Attribute.Standard.PrintQuality>(LocalBridgeClazz, "HIGH"); _HIGHReady = true; } return _HIGHContent; } }
        private static Javax.Print.Attribute.Standard.PrintQuality _HIGHContent = default;
        private static bool _HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrintQuality.html#NORMAL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrintQuality NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Javax.Print.Attribute.Standard.PrintQuality>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
        private static Javax.Print.Attribute.Standard.PrintQuality _NORMALContent = default;
        private static bool _NORMALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrintQuality.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrintQuality.html#getName()"/> 
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