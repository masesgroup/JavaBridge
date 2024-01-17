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

package org.mases.jnet.util.function;

import org.mases.jcobridge.*;

import java.util.function.BiPredicate;

/**
 * The {@link JNetBiPredicate} class represents a generic implementation of
 * {@link BiPredicate}
 */
public final class JNetBiPredicate extends JCListener implements BiPredicate {
    public JNetBiPredicate(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public boolean test(Object e1, Object e2) {
        raiseEvent("test", e1, e2);
        Object retVal = getReturnData();
        return (boolean) retVal;
    }
}