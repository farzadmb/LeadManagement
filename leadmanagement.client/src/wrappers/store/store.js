import { createStore, applyMiddleware } from '../../../node_modules/redux';
import thunk from '../../../node_modules/redux-thunk';

import rootReducer from './rootReducer';

const configureStore = () => applyMiddleware(thunk)(createStore)(rootReducer, window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());

export default configureStore;