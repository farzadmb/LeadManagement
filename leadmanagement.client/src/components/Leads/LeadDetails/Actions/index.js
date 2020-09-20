import React from 'react';

const Actions = (props) => {
    const { lead } = props;
    const { status } = lead;

    return (status === 0) ? (<div>action!!</div>) : null;
};

export default Actions;