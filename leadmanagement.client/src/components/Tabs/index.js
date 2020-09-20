import React from 'react';
import { Tabs, Tab, TabPanel, TabList } from 'react-web-tabs';
import 'react-web-tabs/dist/react-web-tabs.css';

const TabModule = (props) => {
    const {newLeads, processedLeads} = props;

    return (
        <Tabs defaultTab="one">
            <TabList className="my-tablist">
                <Tab tabFor="one" className="my-tab">Invited</Tab>
                <Tab tabFor="two" className="my-tab">Accepted</Tab>
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