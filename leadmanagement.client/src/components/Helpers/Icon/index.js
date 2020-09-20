import React from 'react';

import { faMapMarkerAlt, faBriefcase } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

const Icon = (props) => {
    const {name} = props;

    switch (name)
    {
        case 'location':
            return <FontAwesomeIcon icon={faMapMarkerAlt} />;
        case 'briefcase':
            return <FontAwesomeIcon icon={faBriefcase} />;
        default:
            return null;
    }
};

export default Icon;