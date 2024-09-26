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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region DocumentFilter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html"/>
    /// </summary>
    public partial class DocumentFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DocumentFilter>
    {
        const string _bridgeClassName = "javax.swing.text.DocumentFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DocumentFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DocumentFilter(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region FilterBypass declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html"/>
        /// </summary>
        public partial class FilterBypass : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FilterBypass>
        {
            const string _bridgeClassName = "javax.swing.text.DocumentFilter$FilterBypass";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("FilterBypass class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FilterBypass() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("FilterBypass class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FilterBypass(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region DocumentFilter implementation
    public partial class DocumentFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#insertString(javax.swing.text.DocumentFilter.FilterBypass,int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void InsertString(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, Java.Lang.String arg2, Javax.Swing.Text.AttributeSet arg3)
        {
            IExecuteWithSignature("insertString", "(Ljavax/swing/text/DocumentFilter$FilterBypass;ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#remove(javax.swing.text.DocumentFilter.FilterBypass,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Remove(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("remove", "(Ljavax/swing/text/DocumentFilter$FilterBypass;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.html#replace(javax.swing.text.DocumentFilter.FilterBypass,int,int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.DocumentFilter.FilterBypass"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Replace(Javax.Swing.Text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Java.Lang.String arg3, Javax.Swing.Text.AttributeSet arg4)
        {
            IExecuteWithSignature("replace", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region FilterBypass implementation
        public partial class FilterBypass
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#getDocument()"/> 
            /// </summary>
            public Javax.Swing.Text.Document Document
            {
                get { return IExecuteWithSignature<Javax.Swing.Text.Document>("getDocument", "()Ljavax/swing/text/Document;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void InsertString(int arg0, Java.Lang.String arg1, Javax.Swing.Text.AttributeSet arg2)
            {
                IExecuteWithSignature("insertString", "(ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#remove(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Remove(int arg0, int arg1)
            {
                IExecuteWithSignature("remove", "(II)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DocumentFilter.FilterBypass.html#replace(int,int,java.lang.String,javax.swing.text.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.AttributeSet"/></param>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Replace(int arg0, int arg1, Java.Lang.String arg2, Javax.Swing.Text.AttributeSet arg3)
            {
                IExecuteWithSignature("replace", "(IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}