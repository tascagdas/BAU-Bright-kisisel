import { StyleSheet, Text, View } from 'react-native'
import React from 'react'
import Header from './src/components/Header'
import Main from './src/components/Main'
import Footer from './src/components/Footer'

const App = () => {
    let headerText = "Merhaba Bu header için prop aktarımı"
    let mainText = "Merhaba Bu main için prop aktarımı"
    let footerText = "Merhaba Bu footer için prop aktarımı"

    return (
        // <View style={{ backgroundColor: "violet", height: 500, }}>
        //     <Text style={styles.mytext}>App</Text>
        // </View>
        <>
            <Header isim={headerText} />
            <Main mainText={mainText} />
            <Footer footerText={footerText} />
        </>

    )
}

export default App

const styles = StyleSheet.create({
    mytext: {
        fontSize: 40,
        color: "red",
        textAlign: "center"
    }
})