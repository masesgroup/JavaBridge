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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Metal
{
    #region MetalComboBoxUI
    public partial class MetalComboBoxUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.html#createPropertyChangeListener()"/>
        /// </summary>

        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener CreatePropertyChangeListener()
        {
            return IExecute<Java.Beans.PropertyChangeListener>("createPropertyChangeListener");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.html#configureEditor()"/>
        /// </summary>
        public void ConfigureEditor()
        {
            IExecute("configureEditor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.html#layoutComboBox(java.awt.Container,javax.swing.plaf.metal.MetalComboBoxUI.MetalComboBoxLayoutManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Metal.MetalComboBoxUI.MetalComboBoxLayoutManager"/></param>
        public void LayoutComboBox(Java.Awt.Container arg0, Javax.Swing.Plaf.Metal.MetalComboBoxUI.MetalComboBoxLayoutManager arg1)
        {
            IExecute("layoutComboBox", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.html#unconfigureEditor()"/>
        /// </summary>
        public void UnconfigureEditor()
        {
            IExecute("unconfigureEditor");
        }

        #endregion

        #region Nested classes
        #region MetalComboBoxLayoutManager
        public partial class MetalComboBoxLayoutManager
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.MetalComboBoxLayoutManager.html#%3Cinit%3E(javax.swing.plaf.metal.MetalComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Metal.MetalComboBoxUI"/></param>
            public MetalComboBoxLayoutManager(Javax.Swing.Plaf.Metal.MetalComboBoxUI arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/metal/MetalComboBoxUI.MetalComboBoxLayoutManager.html#superLayout(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void SuperLayout(Java.Awt.Container arg0)
            {
                IExecute("superLayout", arg0);
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