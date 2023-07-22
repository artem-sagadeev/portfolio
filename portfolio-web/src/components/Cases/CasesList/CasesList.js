import './CasesList.css';
import Case from '../Case/Case';
import { useState, useEffect } from 'react';

export default function CasesList() {
    const [data, setData] = useState(null);

    useEffect(() => {
        fetch('http://localhost:5029/api/cases/previews')
            .then((response) => 
                response.json())
            .then((actualData) => {
                setData(actualData);
            });
    }, []);

    return (
        <div className='container'>
            <div className='row my-4'>
                <p className='text-center fs-1'>Мои работы</p>
            </div>

            <div className='row'>
                {data 
                && data.map((item) => 
                    <Case item={item}/>)}
            </div>
        </div>
    );
}
