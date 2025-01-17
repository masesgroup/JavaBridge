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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region JobAttributes declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html"/>
    /// </summary>
    public partial class JobAttributes : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "java.awt.JobAttributes";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JobAttributes() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JobAttributes(params object[] args) : base(args) { }

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
        #region DefaultSelectionType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html"/>
        /// </summary>
        public partial class DefaultSelectionType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DefaultSelectionType>
        {
            const string _bridgeClassName = "java.awt.JobAttributes$DefaultSelectionType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DefaultSelectionType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DefaultSelectionType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region DestinationType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DestinationType.html"/>
        /// </summary>
        public partial class DestinationType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DestinationType>
        {
            const string _bridgeClassName = "java.awt.JobAttributes$DestinationType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DestinationType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DestinationType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region DialogType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html"/>
        /// </summary>
        public partial class DialogType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DialogType>
        {
            const string _bridgeClassName = "java.awt.JobAttributes$DialogType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DialogType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DialogType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region MultipleDocumentHandlingType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.MultipleDocumentHandlingType.html"/>
        /// </summary>
        public partial class MultipleDocumentHandlingType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MultipleDocumentHandlingType>
        {
            const string _bridgeClassName = "java.awt.JobAttributes$MultipleDocumentHandlingType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MultipleDocumentHandlingType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MultipleDocumentHandlingType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region SidesType declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html"/>
        /// </summary>
        public partial class SidesType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SidesType>
        {
            const string _bridgeClassName = "java.awt.JobAttributes$SidesType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SidesType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SidesType(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region JobAttributes implementation
    public partial class JobAttributes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#%3Cinit%3E(int,java.awt.JobAttributes.DefaultSelectionType,java.awt.JobAttributes.DestinationType,java.awt.JobAttributes.DialogType,java.lang.String,int,int,java.awt.JobAttributes.MultipleDocumentHandlingType,int[][],java.lang.String,java.awt.JobAttributes.SidesType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.JobAttributes.DefaultSelectionType"/></param>
        /// <param name="arg2"><see cref="Java.Awt.JobAttributes.DestinationType"/></param>
        /// <param name="arg3"><see cref="Java.Awt.JobAttributes.DialogType"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Awt.JobAttributes.MultipleDocumentHandlingType"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="Java.Lang.String"/></param>
        /// <param name="arg10"><see cref="Java.Awt.JobAttributes.SidesType"/></param>
        public JobAttributes(int arg0, Java.Awt.JobAttributes.DefaultSelectionType arg1, Java.Awt.JobAttributes.DestinationType arg2, Java.Awt.JobAttributes.DialogType arg3, Java.Lang.String arg4, int arg5, int arg6, Java.Awt.JobAttributes.MultipleDocumentHandlingType arg7, int[][] arg8, Java.Lang.String arg9, Java.Awt.JobAttributes.SidesType arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#%3Cinit%3E(java.awt.JobAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.JobAttributes"/></param>
        public JobAttributes(Java.Awt.JobAttributes arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getCopies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setCopies(int)"/>
        /// </summary>
        public int Copies
        {
            get { return IExecuteWithSignature<int>("getCopies", "()I"); } set { IExecuteWithSignature("setCopies", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDefaultSelection()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDefaultSelection(java.awt.JobAttributes.DefaultSelectionType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DefaultSelectionType DefaultSelection
        {
            get { return IExecuteWithSignature<Java.Awt.JobAttributes.DefaultSelectionType>("getDefaultSelection", "()Ljava/awt/JobAttributes$DefaultSelectionType;"); } set { IExecuteWithSignature("setDefaultSelection", "(Ljava/awt/JobAttributes$DefaultSelectionType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDestination()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDestination(java.awt.JobAttributes.DestinationType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DestinationType Destination
        {
            get { return IExecuteWithSignature<Java.Awt.JobAttributes.DestinationType>("getDestination", "()Ljava/awt/JobAttributes$DestinationType;"); } set { IExecuteWithSignature("setDestination", "(Ljava/awt/JobAttributes$DestinationType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getDialog()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setDialog(java.awt.JobAttributes.DialogType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.DialogType Dialog
        {
            get { return IExecuteWithSignature<Java.Awt.JobAttributes.DialogType>("getDialog", "()Ljava/awt/JobAttributes$DialogType;"); } set { IExecuteWithSignature("setDialog", "(Ljava/awt/JobAttributes$DialogType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getFileName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setFileName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String FileName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFileName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFileName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getFromPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setFromPage(int)"/>
        /// </summary>
        public int FromPage
        {
            get { return IExecuteWithSignature<int>("getFromPage", "()I"); } set { IExecuteWithSignature("setFromPage", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMaxPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMaxPage(int)"/>
        /// </summary>
        public int MaxPage
        {
            get { return IExecuteWithSignature<int>("getMaxPage", "()I"); } set { IExecuteWithSignature("setMaxPage", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMinPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMinPage(int)"/>
        /// </summary>
        public int MinPage
        {
            get { return IExecuteWithSignature<int>("getMinPage", "()I"); } set { IExecuteWithSignature("setMinPage", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getMultipleDocumentHandling()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMultipleDocumentHandling(java.awt.JobAttributes.MultipleDocumentHandlingType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.MultipleDocumentHandlingType MultipleDocumentHandling
        {
            get { return IExecuteWithSignature<Java.Awt.JobAttributes.MultipleDocumentHandlingType>("getMultipleDocumentHandling", "()Ljava/awt/JobAttributes$MultipleDocumentHandlingType;"); } set { IExecuteWithSignature("setMultipleDocumentHandling", "(Ljava/awt/JobAttributes$MultipleDocumentHandlingType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getPageRanges()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setPageRanges(int[][])"/>
        /// </summary>
        public int[] PageRanges
        {
            get { return IExecuteWithSignatureArray<int>("getPageRanges", "()[[I"); } set { IExecuteWithSignature("setPageRanges", "([[I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getPrinter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setPrinter(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Printer
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrinter", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPrinter", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getSides()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setSides(java.awt.JobAttributes.SidesType)"/>
        /// </summary>
        public Java.Awt.JobAttributes.SidesType Sides
        {
            get { return IExecuteWithSignature<Java.Awt.JobAttributes.SidesType>("getSides", "()Ljava/awt/JobAttributes$SidesType;"); } set { IExecuteWithSignature("setSides", "(Ljava/awt/JobAttributes$SidesType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#getToPage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setToPage(int)"/>
        /// </summary>
        public int ToPage
        {
            get { return IExecuteWithSignature<int>("getToPage", "()I"); } set { IExecuteWithSignature("setToPage", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#set(java.awt.JobAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.JobAttributes"/></param>
        public void Set(Java.Awt.JobAttributes arg0)
        {
            IExecuteWithSignature("set", "(Ljava/awt/JobAttributes;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setCopiesToDefault()"/>
        /// </summary>
        public void SetCopiesToDefault()
        {
            IExecuteWithSignature("setCopiesToDefault", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setMultipleDocumentHandlingToDefault()"/>
        /// </summary>
        public void SetMultipleDocumentHandlingToDefault()
        {
            IExecuteWithSignature("setMultipleDocumentHandlingToDefault", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.html#setSidesToDefault()"/>
        /// </summary>
        public void SetSidesToDefault()
        {
            IExecuteWithSignature("setSidesToDefault", "()V");
        }

        #endregion

        #region Nested classes
        #region DefaultSelectionType implementation
        public partial class DefaultSelectionType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#ALL"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType ALL { get { if (!_ALLReady) { _ALLContent = SGetField<Java.Awt.JobAttributes.DefaultSelectionType>(LocalBridgeClazz, "ALL"); _ALLReady = true; } return _ALLContent; } }
            private static Java.Awt.JobAttributes.DefaultSelectionType _ALLContent = default;
            private static bool _ALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#RANGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType RANGE { get { if (!_RANGEReady) { _RANGEContent = SGetField<Java.Awt.JobAttributes.DefaultSelectionType>(LocalBridgeClazz, "RANGE"); _RANGEReady = true; } return _RANGEContent; } }
            private static Java.Awt.JobAttributes.DefaultSelectionType _RANGEContent = default;
            private static bool _RANGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DefaultSelectionType.html#SELECTION"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DefaultSelectionType SELECTION { get { if (!_SELECTIONReady) { _SELECTIONContent = SGetField<Java.Awt.JobAttributes.DefaultSelectionType>(LocalBridgeClazz, "SELECTION"); _SELECTIONReady = true; } return _SELECTIONContent; } }
            private static Java.Awt.JobAttributes.DefaultSelectionType _SELECTIONContent = default;
            private static bool _SELECTIONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DestinationType implementation
        public partial class DestinationType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DestinationType.html#FILE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DestinationType FILE { get { if (!_FILEReady) { _FILEContent = SGetField<Java.Awt.JobAttributes.DestinationType>(LocalBridgeClazz, "FILE"); _FILEReady = true; } return _FILEContent; } }
            private static Java.Awt.JobAttributes.DestinationType _FILEContent = default;
            private static bool _FILEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DestinationType.html#PRINTER"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DestinationType PRINTER { get { if (!_PRINTERReady) { _PRINTERContent = SGetField<Java.Awt.JobAttributes.DestinationType>(LocalBridgeClazz, "PRINTER"); _PRINTERReady = true; } return _PRINTERContent; } }
            private static Java.Awt.JobAttributes.DestinationType _PRINTERContent = default;
            private static bool _PRINTERReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DialogType implementation
        public partial class DialogType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#COMMON"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType COMMON { get { if (!_COMMONReady) { _COMMONContent = SGetField<Java.Awt.JobAttributes.DialogType>(LocalBridgeClazz, "COMMON"); _COMMONReady = true; } return _COMMONContent; } }
            private static Java.Awt.JobAttributes.DialogType _COMMONContent = default;
            private static bool _COMMONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#NATIVE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType NATIVE { get { if (!_NATIVEReady) { _NATIVEContent = SGetField<Java.Awt.JobAttributes.DialogType>(LocalBridgeClazz, "NATIVE"); _NATIVEReady = true; } return _NATIVEContent; } }
            private static Java.Awt.JobAttributes.DialogType _NATIVEContent = default;
            private static bool _NATIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.DialogType.html#NONE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.DialogType NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Java.Awt.JobAttributes.DialogType>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Java.Awt.JobAttributes.DialogType _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MultipleDocumentHandlingType implementation
        public partial class MultipleDocumentHandlingType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.MultipleDocumentHandlingType.html#SEPARATE_DOCUMENTS_COLLATED_COPIES"/>
            /// </summary>
            public static Java.Awt.JobAttributes.MultipleDocumentHandlingType SEPARATE_DOCUMENTS_COLLATED_COPIES { get { if (!_SEPARATE_DOCUMENTS_COLLATED_COPIESReady) { _SEPARATE_DOCUMENTS_COLLATED_COPIESContent = SGetField<Java.Awt.JobAttributes.MultipleDocumentHandlingType>(LocalBridgeClazz, "SEPARATE_DOCUMENTS_COLLATED_COPIES"); _SEPARATE_DOCUMENTS_COLLATED_COPIESReady = true; } return _SEPARATE_DOCUMENTS_COLLATED_COPIESContent; } }
            private static Java.Awt.JobAttributes.MultipleDocumentHandlingType _SEPARATE_DOCUMENTS_COLLATED_COPIESContent = default;
            private static bool _SEPARATE_DOCUMENTS_COLLATED_COPIESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.MultipleDocumentHandlingType.html#SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"/>
            /// </summary>
            public static Java.Awt.JobAttributes.MultipleDocumentHandlingType SEPARATE_DOCUMENTS_UNCOLLATED_COPIES { get { if (!_SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady) { _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent = SGetField<Java.Awt.JobAttributes.MultipleDocumentHandlingType>(LocalBridgeClazz, "SEPARATE_DOCUMENTS_UNCOLLATED_COPIES"); _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady = true; } return _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent; } }
            private static Java.Awt.JobAttributes.MultipleDocumentHandlingType _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESContent = default;
            private static bool _SEPARATE_DOCUMENTS_UNCOLLATED_COPIESReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SidesType implementation
        public partial class SidesType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#ONE_SIDED"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType ONE_SIDED { get { if (!_ONE_SIDEDReady) { _ONE_SIDEDContent = SGetField<Java.Awt.JobAttributes.SidesType>(LocalBridgeClazz, "ONE_SIDED"); _ONE_SIDEDReady = true; } return _ONE_SIDEDContent; } }
            private static Java.Awt.JobAttributes.SidesType _ONE_SIDEDContent = default;
            private static bool _ONE_SIDEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#TWO_SIDED_LONG_EDGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType TWO_SIDED_LONG_EDGE { get { if (!_TWO_SIDED_LONG_EDGEReady) { _TWO_SIDED_LONG_EDGEContent = SGetField<Java.Awt.JobAttributes.SidesType>(LocalBridgeClazz, "TWO_SIDED_LONG_EDGE"); _TWO_SIDED_LONG_EDGEReady = true; } return _TWO_SIDED_LONG_EDGEContent; } }
            private static Java.Awt.JobAttributes.SidesType _TWO_SIDED_LONG_EDGEContent = default;
            private static bool _TWO_SIDED_LONG_EDGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/JobAttributes.SidesType.html#TWO_SIDED_SHORT_EDGE"/>
            /// </summary>
            public static Java.Awt.JobAttributes.SidesType TWO_SIDED_SHORT_EDGE { get { if (!_TWO_SIDED_SHORT_EDGEReady) { _TWO_SIDED_SHORT_EDGEContent = SGetField<Java.Awt.JobAttributes.SidesType>(LocalBridgeClazz, "TWO_SIDED_SHORT_EDGE"); _TWO_SIDED_SHORT_EDGEReady = true; } return _TWO_SIDED_SHORT_EDGEContent; } }
            private static Java.Awt.JobAttributes.SidesType _TWO_SIDED_SHORT_EDGEContent = default;
            private static bool _TWO_SIDED_SHORT_EDGEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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