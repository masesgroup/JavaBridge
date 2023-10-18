/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region ServiceUIFactory
    public partial class ServiceUIFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#ABOUT_UIROLE"/>
        /// </summary>
        public static int ABOUT_UIROLE { get { return SGetField<int>(LocalBridgeClazz, "ABOUT_UIROLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#ADMIN_UIROLE"/>
        /// </summary>
        public static int ADMIN_UIROLE { get { return SGetField<int>(LocalBridgeClazz, "ADMIN_UIROLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#MAIN_UIROLE"/>
        /// </summary>
        public static int MAIN_UIROLE { get { return SGetField<int>(LocalBridgeClazz, "MAIN_UIROLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#RESERVED_UIROLE"/>
        /// </summary>
        public static int RESERVED_UIROLE { get { return SGetField<int>(LocalBridgeClazz, "RESERVED_UIROLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#DIALOG_UI"/>
        /// </summary>
        public static string DIALOG_UI { get { return SGetField<string>(LocalBridgeClazz, "DIALOG_UI"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#JCOMPONENT_UI"/>
        /// </summary>
        public static string JCOMPONENT_UI { get { return SGetField<string>(LocalBridgeClazz, "JCOMPONENT_UI"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#JDIALOG_UI"/>
        /// </summary>
        public static string JDIALOG_UI { get { return SGetField<string>(LocalBridgeClazz, "JDIALOG_UI"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#PANEL_UI"/>
        /// </summary>
        public static string PANEL_UI { get { return SGetField<string>(LocalBridgeClazz, "PANEL_UI"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#getUI(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetUI(int arg0, string arg1)
        {
            return IExecute("getUI", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#getUIClassNamesForRole(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] GetUIClassNamesForRole(int arg0)
        {
            return IExecuteArray<string>("getUIClassNamesForRole", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}