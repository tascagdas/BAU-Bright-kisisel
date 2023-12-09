import React from 'react';
import SearchForm from '../../Components/SearchForm';
import Users from '../../Components/Users';

const SearchPage = () => {
    return (
        <>
            <SearchForm />
            {/* Buraya searhch işlemi için bir component
            Bir de sonuçları göstermek için bir component tasarlayacağız. */}
            <Users />
        </>
    )
}

export default SearchPage;