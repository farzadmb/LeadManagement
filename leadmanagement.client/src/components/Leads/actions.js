import axios from 'axios';
import * as actionTypes from './actionTypes';

const baseUrl = 'http://localhost:8090';
const leadsUrl = baseUrl + '/jobs';

const getAllLeads = () => (
    (dispatch) => {
        dispatch({ type: actionTypes.GET_ALL_LEADS_REQUEST });

        axios.get(leadsUrl)
            .then(response => {
                dispatch({ type: actionTypes.GET_ALL_LEADS_SUCCESS, leads: response.data });
            })
            .catch(error => {
                dispatch({ type: actionTypes.GET_ALL_LEADS_FAILED, error });
            });
    });

const updateLeadStatus = (id, status) => (
    (dispatch) => {
        dispatch({ type: actionTypes.UPDATE_LEAD_STATUS_REQUEST });

        axios.put(leadsUrl, { id, status })
            .then(response => {
                dispatch({ type: actionTypes.UPDATE_LEAD_STATUS_SUCCESS, id, status });
            })
            .catch(error => {
                console.log('error: ', error);
                dispatch({ type: actionTypes.UPDATE_LEAD_STATUS_FAILED, error });
            });
    });

export {
    getAllLeads,
    updateLeadStatus
};