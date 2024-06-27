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

namespace Javax.Swing
{
    #region Timer
    public partial class Timer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#%3Cinit%3E(int,java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public Timer(int arg0, Java.Awt.EventNs.ActionListener arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#getLogTimers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setLogTimers(boolean)"/>
        /// </summary>
        public static bool LogTimers
        {
            get { return SExecuteWithSignature<bool>(LocalBridgeClazz, "getLogTimers", "()Z"); } set { SExecuteWithSignature(LocalBridgeClazz, "setLogTimers", "(Z)V", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#getActionCommand()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setActionCommand(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setActionCommand", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#getActionListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ActionListener[] ActionListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ActionListener>("getActionListeners", "()[Ljava/awt/event/ActionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#getDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setDelay(int)"/>
        /// </summary>
        public int Delay
        {
            get { return IExecuteWithSignature<int>("getDelay", "()I"); } set { IExecuteWithSignature("setDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#getInitialDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setInitialDelay(int)"/>
        /// </summary>
        public int InitialDelay
        {
            get { return IExecuteWithSignature<int>("getInitialDelay", "()I"); } set { IExecuteWithSignature("setInitialDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#isCoalesce()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCoalesce()
        {
            return IExecuteWithSignature<bool>("isCoalesce", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#isRepeats()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRepeats()
        {
            return IExecuteWithSignature<bool>("isRepeats", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#isRunning()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRunning()
        {
            return IExecuteWithSignature<bool>("isRunning", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#addActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void AddActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("addActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#removeActionListener(java.awt.event.ActionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionListener"/></param>
        public void RemoveActionListener(Java.Awt.EventNs.ActionListener arg0)
        {
            IExecuteWithSignature("removeActionListener", "(Ljava/awt/event/ActionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#restart()"/>
        /// </summary>
        public void Restart()
        {
            IExecuteWithSignature("restart", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setCoalesce(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCoalesce(bool arg0)
        {
            IExecuteWithSignature("setCoalesce", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#setRepeats(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRepeats(bool arg0)
        {
            IExecuteWithSignature("setRepeats", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Timer.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}