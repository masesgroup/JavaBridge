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

namespace Javax.Swing.Table
{
    #region TableRowSorter
    public partial class TableRowSorter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#%3Cinit%3E(javax.swing.table.TableModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        public TableRowSorter(Javax.Swing.Table.TableModel arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#getStringConverter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#setStringConverter(javax.swing.table.TableStringConverter)"/>
        /// </summary>
        public Javax.Swing.Table.TableStringConverter StringConverter
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableStringConverter>("getStringConverter", "()Ljavax/swing/table/TableStringConverter;"); } set { IExecuteWithSignature("setStringConverter", "(Ljavax/swing/table/TableStringConverter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#setModel(javax.swing.table.TableModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        public void SetModel(Javax.Swing.Table.TableModel arg0)
        {
            IExecuteWithSignature("setModel", "(Ljavax/swing/table/TableModel;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableRowSorter<M>
    public partial class TableRowSorter<M>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#%3Cinit%3E(javax.swing.table.TableModel)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="M"/></param>
        public TableRowSorter(M arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.TableRowSorter{M}"/> to <see cref="Javax.Swing.Table.TableRowSorter"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableRowSorter(Javax.Swing.Table.TableRowSorter<M> t) => t.Cast<Javax.Swing.Table.TableRowSorter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#getStringConverter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#setStringConverter(javax.swing.table.TableStringConverter)"/>
        /// </summary>
        public Javax.Swing.Table.TableStringConverter StringConverter
        {
            get { return IExecuteWithSignature<Javax.Swing.Table.TableStringConverter>("getStringConverter", "()Ljavax/swing/table/TableStringConverter;"); } set { IExecuteWithSignature("setStringConverter", "(Ljavax/swing/table/TableStringConverter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableRowSorter.html#setModel(javax.swing.table.TableModel)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="M"/></param>
        public void SetModel(M arg0)
        {
            IExecuteWithSignature("setModel", "(Ljavax/swing/table/TableModel;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}