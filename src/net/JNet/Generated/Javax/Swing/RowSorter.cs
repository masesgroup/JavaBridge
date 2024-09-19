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

namespace Javax.Swing
{
    #region RowSorter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html"/>
    /// </summary>
    public partial class RowSorter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RowSorter>
    {
        const string _bridgeClassName = "javax.swing.RowSorter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RowSorter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSorter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RowSorter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSorter(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region SortKey declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html"/>
        /// </summary>
        public partial class SortKey : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SortKey>
        {
            const string _bridgeClassName = "javax.swing.RowSorter$SortKey";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SortKey() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SortKey(params object[] args) : base(args) { }

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

    #region RowSorter<M> declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html"/>
    /// </summary>
    /// <typeparam name="M"></typeparam>
    public partial class RowSorter<M> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RowSorter<M>>
    {
        const string _bridgeClassName = "javax.swing.RowSorter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RowSorter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSorter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RowSorter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RowSorter(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
    
    }
    #endregion

    #region RowSorter implementation
    public partial class RowSorter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModel()"/> 
        /// </summary>
        public object Model
        {
            get { return IExecuteWithSignature("getModel", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModelRowCount()"/> 
        /// </summary>
        public int ModelRowCount
        {
            get { return IExecuteWithSignature<int>("getModelRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#setSortKeys(java.util.List)"/>
        /// </summary>
        public Java.Util.List SortKeys
        {
            get { return IExecuteWithSignature<Java.Util.List>("getSortKeys", "()Ljava/util/List;"); } set { IExecuteWithSignature("setSortKeys", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getViewRowCount()"/> 
        /// </summary>
        public int ViewRowCount
        {
            get { return IExecuteWithSignature<int>("getViewRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToModel(int arg0)
        {
            return IExecuteWithSignature<int>("convertRowIndexToModel", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToView(int arg0)
        {
            return IExecuteWithSignature<int>("convertRowIndexToView", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#allRowsChanged()"/>
        /// </summary>
        public void AllRowsChanged()
        {
            IExecuteWithSignature("allRowsChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#modelStructureChanged()"/>
        /// </summary>
        public void ModelStructureChanged()
        {
            IExecuteWithSignature("modelStructureChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsDeleted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsDeleted(int arg0, int arg1)
        {
            IExecute("rowsDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsInserted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsInserted(int arg0, int arg1)
        {
            IExecute("rowsInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1, int arg2)
        {
            IExecute("rowsUpdated", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1)
        {
            IExecute("rowsUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#toggleSortOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ToggleSortOrder(int arg0)
        {
            IExecuteWithSignature("toggleSortOrder", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#addRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void AddRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecuteWithSignature("addRowSorterListener", "(Ljavax/swing/event/RowSorterListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#removeRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void RemoveRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecuteWithSignature("removeRowSorterListener", "(Ljavax/swing/event/RowSorterListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region SortKey implementation
        public partial class SortKey
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#%3Cinit%3E(int,javax.swing.SortOrder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.SortOrder"/></param>
            public SortKey(int arg0, Javax.Swing.SortOrder arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#getColumn()"/> 
            /// </summary>
            public int Column
            {
                get { return IExecuteWithSignature<int>("getColumn", "()I"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#getSortOrder()"/> 
            /// </summary>
            public Javax.Swing.SortOrder SortOrder
            {
                get { return IExecuteWithSignature<Javax.Swing.SortOrder>("getSortOrder", "()Ljavax/swing/SortOrder;"); }
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

    #region RowSorter<M> implementation
    public partial class RowSorter<M>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.RowSorter{M}"/> to <see cref="Javax.Swing.RowSorter"/>
        /// </summary>
        public static implicit operator Javax.Swing.RowSorter(Javax.Swing.RowSorter<M> t) => t.Cast<Javax.Swing.RowSorter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModel()"/> 
        /// </summary>
        public M Model
        {
            get { return IExecuteWithSignature<M>("getModel", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModelRowCount()"/> 
        /// </summary>
        public int ModelRowCount
        {
            get { return IExecuteWithSignature<int>("getModelRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#setSortKeys(java.util.List)"/>
        /// </summary>
        public Java.Util.List SortKeys
        {
            get { return IExecuteWithSignature<Java.Util.List>("getSortKeys", "()Ljava/util/List;"); } set { IExecuteWithSignature("setSortKeys", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getViewRowCount()"/> 
        /// </summary>
        public int ViewRowCount
        {
            get { return IExecuteWithSignature<int>("getViewRowCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToModel(int arg0)
        {
            return IExecuteWithSignature<int>("convertRowIndexToModel", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToView(int arg0)
        {
            return IExecuteWithSignature<int>("convertRowIndexToView", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#allRowsChanged()"/>
        /// </summary>
        public void AllRowsChanged()
        {
            IExecuteWithSignature("allRowsChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#modelStructureChanged()"/>
        /// </summary>
        public void ModelStructureChanged()
        {
            IExecuteWithSignature("modelStructureChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsDeleted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsDeleted(int arg0, int arg1)
        {
            IExecute("rowsDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsInserted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsInserted(int arg0, int arg1)
        {
            IExecute("rowsInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1, int arg2)
        {
            IExecute("rowsUpdated", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1)
        {
            IExecute("rowsUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#toggleSortOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ToggleSortOrder(int arg0)
        {
            IExecuteWithSignature("toggleSortOrder", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#addRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void AddRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecuteWithSignature("addRowSorterListener", "(Ljavax/swing/event/RowSorterListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#removeRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void RemoveRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecuteWithSignature("removeRowSorterListener", "(Ljavax/swing/event/RowSorterListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}