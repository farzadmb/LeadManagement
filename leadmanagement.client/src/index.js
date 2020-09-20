import React from 'react';
import ReactDOM from 'react-dom';
import { Route, Switch, Redirect, BrowserRouter } from 'react-router-dom';
import * as serviceWorker from './serviceWorker';
import configureStore from './wrappers/store/store';
import { Provider } from 'react-redux';

import Leads from './components/Leads';

const store = configureStore({});

const Root = () => {
  return (
    <BrowserRouter>
      <Switch>
        <Route path='/' component={Leads} />
        <Redirect to="/" />
      </Switch>
    </BrowserRouter>
  );
};

ReactDOM.render(
  <React.StrictMode>
    <Provider store={store}>
      <Root />
    </Provider>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
