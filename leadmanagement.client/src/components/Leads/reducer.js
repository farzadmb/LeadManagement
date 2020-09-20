import * as actionTypes from './actionTypes';

const initialState = {
    leads: [],
    isLoading: true,
    error: null
};

const getAllLeadsRequest = (state) => ({ ...state, isLoading: true });

const getAllLeadsSuccess = (state, leads) => ({ ...state, leads, isLoading: false, error: null });

const getAllLeadsFailed = (state, error) => ({ ...state, isLoading: false, error });

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case (actionTypes.GET_ALL_LEADS_REQUEST):
            return getAllLeadsRequest(state);
        case (actionTypes.GET_ALL_LEADS_SUCCESS):
            return getAllLeadsSuccess(state, action.leads);
        case (actionTypes.GET_ALL_LEADS_FAILED):
            return getAllLeadsFailed(state, action.error);
        default:
            return state;
    };

};

export default reducer;