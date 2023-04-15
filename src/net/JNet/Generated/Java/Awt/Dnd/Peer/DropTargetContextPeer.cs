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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd.Peer
{
    #region DropTargetContextPeer
    public partial class DropTargetContextPeer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getDropTarget()"/> 
        /// </summary>
        public Java.Awt.Dnd.DropTarget DropTarget
        {
            get { return IExecute<Java.Awt.Dnd.DropTarget>("getDropTarget"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#isTransferableJVMLocal()"/> 
        /// </summary>
        public bool IsTransferableJVMLocal
        {
            get { return IExecute<bool>("isTransferableJVMLocal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTargetActions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#setTargetActions(int)"/>
        /// </summary>
        public int TargetActions
        {
            get { return IExecute<int>("getTargetActions"); } set { IExecute("setTargetActions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferable()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecute<Java.Awt.Datatransfer.Transferable>("getTransferable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#getTransferDataFlavors()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.DataFlavor[] TransferDataFlavors
        {
            get { return IExecuteArray<Java.Awt.Datatransfer.DataFlavor>("getTransferDataFlavors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrag(int arg0)
        {
            IExecute("acceptDrag", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#acceptDrop(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcceptDrop(int arg0)
        {
            IExecute("acceptDrop", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#dropComplete(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void DropComplete(bool arg0)
        {
            IExecute("dropComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrag()"/>
        /// </summary>
        public void RejectDrag()
        {
            IExecute("rejectDrag");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/peer/DropTargetContextPeer.html#rejectDrop()"/>
        /// </summary>
        public void RejectDrop()
        {
            IExecute("rejectDrop");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}