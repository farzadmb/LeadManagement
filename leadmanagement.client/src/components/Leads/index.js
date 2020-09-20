import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';

import LeadList from './LeadList';
import Tabs from '../Tabs';
import * as actions from './actions';

const Leads = (props) => {
    const dispatch = useDispatch();
    const leads = useSelector(state => state.leads.leads);
    const isLoading = useSelector(state => state.leads.isLoading);

    useEffect(() => {
        dispatch(actions.getAllLeads());
    }, [dispatch]);

    const onStatusUpdate = (id, status) => {
        dispatch(actions.updateLeadStatus(id, status));
    };

    const createTabContent = (leads) => (<LeadList leads={leads} onStatusUpdate={onStatusUpdate} />);

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

        const newTab = createTabContent(leads.filter(l => l.status === 0));
        const processedTab = createTabContent(leads.filter(l => l.status !== 0));

        return <Tabs newLeads={newTab} processedLeads={processedTab}/>
    };

    return (
        <React.Fragment>
            {generateContent()}
        </React.Fragment>
    )
};

export default Leads;