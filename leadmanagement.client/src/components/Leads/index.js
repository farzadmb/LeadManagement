import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';

import LeadList from './LeadList';
import * as actions from './actions';

const Leads = (props) => {
    const dispatch = useDispatch();
    const leads = useSelector(state => state.leads.leads);
    const isLoading = useSelector(state => state.leads.isLoading);

    useEffect(() => {
        dispatch(actions.getAllLeads());
    }, [dispatch]);

    const generateContent = () => {
        if (isLoading) {
            return (
                <p>
                    <em>Loading...</em>
                </p>
            );
        }

        if (!leads || !Array.isArray(leads)) {
            return null;
        }

        return <LeadList leads={leads} />;
    };

    return (
        <React.Fragment>
            <div>
                Leads list
            </div>
            {generateContent()}
        </React.Fragment>
    )
};

export default Leads;