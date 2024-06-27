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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Datatransfer
{
    #region IFlavorMap
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IFlavorMap
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorMap.html#getNativesForFlavors(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, Java.Lang.String> GetNativesForFlavors(Java.Awt.Datatransfer.DataFlavor[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorMap.html#getFlavorsForNatives(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        Java.Util.Map<Java.Lang.String, Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNatives(Java.Lang.String[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region FlavorMap
    public partial class FlavorMap : Java.Awt.Datatransfer.IFlavorMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorMap.html#getNativesForFlavors(java.awt.datatransfer.DataFlavor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Datatransfer.DataFlavor"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, Java.Lang.String> GetNativesForFlavors(Java.Awt.Datatransfer.DataFlavor[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Awt.Datatransfer.DataFlavor, Java.Lang.String>>("getNativesForFlavors", "([Ljava/awt/datatransfer/DataFlavor;)Ljava/util/Map;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.datatransfer/java/awt/datatransfer/FlavorMap.html#getFlavorsForNatives(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Awt.Datatransfer.DataFlavor> GetFlavorsForNatives(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Awt.Datatransfer.DataFlavor>>("getFlavorsForNatives", "([Ljava/lang/String;)Ljava/util/Map;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}