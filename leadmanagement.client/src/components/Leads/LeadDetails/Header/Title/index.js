import React from 'react';
import './style.css';

import DateFormatter from '../../../../Helpers/DateFormatter';

const Title = (props) => {
    const { contact, time } = props;
    const { name } = contact;

    console.log('time: ', time);
    return (
        <React.Fragment>
            <div className='numberCircle'>
                {name.charAt(0)}
            </div>
            <div>
                <div>
                    {name.split(" ")[0]}
                </div>
                <div>
                    <DateFormatter time={time} />
                </div>
            </div>
        </React.Fragment>
    );
}

export default Title;