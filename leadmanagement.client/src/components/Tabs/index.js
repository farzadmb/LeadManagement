import React from 'react';
import { Tabs, Tab, TabPanel, TabList } from 'react-web-tabs';

const TabModule = (props) => {
    const {newLeads, processedLeads} = props;

    return (
        <Tabs defaultTab="one">
            <TabList>
                <Tab tabFor="one">Invited</Tab>
                <Tab tabFor="two">Accepted</Tab>
            </TabList>
            <TabPanel tabId="one">
                {newLeads}
            </TabPanel>
            <TabPanel tabId="two">
                {processedLeads}
            </TabPanel>
        </Tabs>
    );
};

export default TabModule;