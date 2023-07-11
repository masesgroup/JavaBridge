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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region AccessibleRelation
    public partial class AccessibleRelation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#%3Cinit%3E(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public AccessibleRelation(string arg0, object arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public AccessibleRelation(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CHILD_NODE_OF"/>
        /// </summary>
        public static string CHILD_NODE_OF { get { return SGetField<string>(LocalBridgeClazz, "CHILD_NODE_OF"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CHILD_NODE_OF_PROPERTY"/>
        /// </summary>
        public static string CHILD_NODE_OF_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CHILD_NODE_OF_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY"/>
        /// </summary>
        public static string CONTROLLED_BY { get { return SGetField<string>(LocalBridgeClazz, "CONTROLLED_BY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY_PROPERTY"/>
        /// </summary>
        public static string CONTROLLED_BY_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CONTROLLED_BY_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR"/>
        /// </summary>
        public static string CONTROLLER_FOR { get { return SGetField<string>(LocalBridgeClazz, "CONTROLLER_FOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR_PROPERTY"/>
        /// </summary>
        public static string CONTROLLER_FOR_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "CONTROLLER_FOR_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY"/>
        /// </summary>
        public static string EMBEDDED_BY { get { return SGetField<string>(LocalBridgeClazz, "EMBEDDED_BY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY_PROPERTY"/>
        /// </summary>
        public static string EMBEDDED_BY_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "EMBEDDED_BY_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS"/>
        /// </summary>
        public static string EMBEDS { get { return SGetField<string>(LocalBridgeClazz, "EMBEDS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS_PROPERTY"/>
        /// </summary>
        public static string EMBEDS_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "EMBEDS_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM"/>
        /// </summary>
        public static string FLOWS_FROM { get { return SGetField<string>(LocalBridgeClazz, "FLOWS_FROM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM_PROPERTY"/>
        /// </summary>
        public static string FLOWS_FROM_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FLOWS_FROM_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO"/>
        /// </summary>
        public static string FLOWS_TO { get { return SGetField<string>(LocalBridgeClazz, "FLOWS_TO"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO_PROPERTY"/>
        /// </summary>
        public static string FLOWS_TO_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "FLOWS_TO_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR"/>
        /// </summary>
        public static string LABEL_FOR { get { return SGetField<string>(LocalBridgeClazz, "LABEL_FOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR_PROPERTY"/>
        /// </summary>
        public static string LABEL_FOR_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "LABEL_FOR_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY"/>
        /// </summary>
        public static string LABELED_BY { get { return SGetField<string>(LocalBridgeClazz, "LABELED_BY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY_PROPERTY"/>
        /// </summary>
        public static string LABELED_BY_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "LABELED_BY_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF"/>
        /// </summary>
        public static string MEMBER_OF { get { return SGetField<string>(LocalBridgeClazz, "MEMBER_OF"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF_PROPERTY"/>
        /// </summary>
        public static string MEMBER_OF_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "MEMBER_OF_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF"/>
        /// </summary>
        public static string PARENT_WINDOW_OF { get { return SGetField<string>(LocalBridgeClazz, "PARENT_WINDOW_OF"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string PARENT_WINDOW_OF_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "PARENT_WINDOW_OF_PROPERTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF"/>
        /// </summary>
        public static string SUBWINDOW_OF { get { return SGetField<string>(LocalBridgeClazz, "SUBWINDOW_OF"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string SUBWINDOW_OF_PROPERTY { get { return SGetField<string>(LocalBridgeClazz, "SUBWINDOW_OF_PROPERTY"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#getKey()"/> 
        /// </summary>
        public string Key
        {
            get { return IExecute<string>("getKey"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#getTarget()"/> 
        /// </summary>
        public object[] Target
        {
            get { return IExecuteArray<object>("getTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#setTarget(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTarget(object arg0)
        {
            IExecute("setTarget", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#setTarget(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetTarget(object[] arg0)
        {
            IExecute("setTarget", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}