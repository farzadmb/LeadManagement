import { combineReducers } from '../../../node_modules/redux';

import leadReducer from '../../components/Leads/reducer';

const rootReducer = combineReducers({
    leads: leadReducer
});

export default rootReducer;