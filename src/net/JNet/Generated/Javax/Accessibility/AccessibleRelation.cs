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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
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
        public static string CHILD_NODE_OF => Clazz.GetField<string>("CHILD_NODE_OF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CHILD_NODE_OF_PROPERTY"/>
        /// </summary>
        public static string CHILD_NODE_OF_PROPERTY => Clazz.GetField<string>("CHILD_NODE_OF_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY"/>
        /// </summary>
        public static string CONTROLLED_BY => Clazz.GetField<string>("CONTROLLED_BY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLED_BY_PROPERTY"/>
        /// </summary>
        public static string CONTROLLED_BY_PROPERTY => Clazz.GetField<string>("CONTROLLED_BY_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR"/>
        /// </summary>
        public static string CONTROLLER_FOR => Clazz.GetField<string>("CONTROLLER_FOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#CONTROLLER_FOR_PROPERTY"/>
        /// </summary>
        public static string CONTROLLER_FOR_PROPERTY => Clazz.GetField<string>("CONTROLLER_FOR_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY"/>
        /// </summary>
        public static string EMBEDDED_BY => Clazz.GetField<string>("EMBEDDED_BY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDDED_BY_PROPERTY"/>
        /// </summary>
        public static string EMBEDDED_BY_PROPERTY => Clazz.GetField<string>("EMBEDDED_BY_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS"/>
        /// </summary>
        public static string EMBEDS => Clazz.GetField<string>("EMBEDS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#EMBEDS_PROPERTY"/>
        /// </summary>
        public static string EMBEDS_PROPERTY => Clazz.GetField<string>("EMBEDS_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM"/>
        /// </summary>
        public static string FLOWS_FROM => Clazz.GetField<string>("FLOWS_FROM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_FROM_PROPERTY"/>
        /// </summary>
        public static string FLOWS_FROM_PROPERTY => Clazz.GetField<string>("FLOWS_FROM_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO"/>
        /// </summary>
        public static string FLOWS_TO => Clazz.GetField<string>("FLOWS_TO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#FLOWS_TO_PROPERTY"/>
        /// </summary>
        public static string FLOWS_TO_PROPERTY => Clazz.GetField<string>("FLOWS_TO_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR"/>
        /// </summary>
        public static string LABEL_FOR => Clazz.GetField<string>("LABEL_FOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABEL_FOR_PROPERTY"/>
        /// </summary>
        public static string LABEL_FOR_PROPERTY => Clazz.GetField<string>("LABEL_FOR_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY"/>
        /// </summary>
        public static string LABELED_BY => Clazz.GetField<string>("LABELED_BY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#LABELED_BY_PROPERTY"/>
        /// </summary>
        public static string LABELED_BY_PROPERTY => Clazz.GetField<string>("LABELED_BY_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF"/>
        /// </summary>
        public static string MEMBER_OF => Clazz.GetField<string>("MEMBER_OF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#MEMBER_OF_PROPERTY"/>
        /// </summary>
        public static string MEMBER_OF_PROPERTY => Clazz.GetField<string>("MEMBER_OF_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF"/>
        /// </summary>
        public static string PARENT_WINDOW_OF => Clazz.GetField<string>("PARENT_WINDOW_OF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#PARENT_WINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string PARENT_WINDOW_OF_PROPERTY => Clazz.GetField<string>("PARENT_WINDOW_OF_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF"/>
        /// </summary>
        public static string SUBWINDOW_OF => Clazz.GetField<string>("SUBWINDOW_OF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleRelation.html#SUBWINDOW_OF_PROPERTY"/>
        /// </summary>
        public static string SUBWINDOW_OF_PROPERTY => Clazz.GetField<string>("SUBWINDOW_OF_PROPERTY");
        
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
            IExecute("setTarget", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}