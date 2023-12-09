import React from 'react'
import SearchForm from '../../Components/SearchForm'
import Users from '../../Components/Users'

const SearchPage = () => {
  return (
    <>
      <SearchForm />
      {/* Buraya Search islemi icin bir component ve sonuclari gostermek icin bir component tasarlanicak */}
      <Users />
    </>
  )
}

export default SearchPage