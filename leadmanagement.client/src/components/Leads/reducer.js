import * as actionTypes from './actionTypes';

const initialState = {
    leads: [],
    isLoading: true,
    error: null
};

const getAllLeadsRequest = (state) => ({ ...state, isLoading: true });

const getAllLeadsSuccess = (state, leads) => ({ ...state, leads, isLoading: false, error: null });

const getAllLeadsFailed = (state, error) => ({ ...state, isLoading: false, error });

const updateLeadStatusRequest = (state) => ({ ...state, isLoading: true });

const updateLeadStatusSuccess = (state, id, status) => {
    const updatedState = { ...state };
    const lead = updatedState.leads.find(l => l.id === id);
    const updatedLead = { ...lead, status };

    const updatedLeads = updatedState.leads.map(l => (l.id !== id) ? l : updatedLead);

    return { ...state, leads: updatedLeads, isLoading: false, error: null };
};

const updateLeadStatusFailed = (state, error) => ({ ...state, isLoading: false, error });

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case (actionTypes.GET_ALL_LEADS_REQUEST):
            return getAllLeadsRequest(state);
        case (actionTypes.GET_ALL_LEADS_SUCCESS):
            return getAllLeadsSuccess(state, action.leads);
        case (actionTypes.GET_ALL_LEADS_FAILED):
            return getAllLeadsFailed(state, action.error);
        case (actionTypes.UPDATE_LEAD_STATUS_REQUEST):
            return updateLeadStatusRequest(state);
        case (actionTypes.UPDATE_LEAD_STATUS_SUCCESS):
            return updateLeadStatusSuccess(state, action.id, action.status);
        case (actionTypes.UPDATE_LEAD_STATUS_FAILED):
            return updateLeadStatusFailed(state, action.error);
        default:
            return state;
    };
};

export default reducer;