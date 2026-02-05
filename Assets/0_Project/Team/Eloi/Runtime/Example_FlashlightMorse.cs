using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArcNes.Eloi
{

    /// <summary>
    /// To Test and verify
    /// </summary>
    public class Example_FlashlightMorse : MonoBehaviour
    {
        public Example_XboxArcRaidersBasicWrapper m_arcWrapper;
        public float m_dotDuration = 0.2f;
        public float m_dashDuration = 0.6f;
        public float m_letterPauseDuration = 0.6f;
        public float m_wordPauseDuration = 1.4f;

        public void SendSOS()
        {
            SendMorseSequenceAsDotAndDash("... --- ...");
        }
        public void SendHelloWorld()
        {
            SendText("HELLO WORLD");
        }

        public void SendText(string text)
        {
            string morseSequence = ConvertTextToMorse(text);
            SendMorseSequenceAsDotAndDash(morseSequence);
            Debug.Log("Sending text in Morse: " + text + " as " + morseSequence);
        }
        public char m_morseForA = 'A';

        private string ConvertTextToMorse(string text)
        {
            string morseSequence = "";
            foreach (char c in text.ToUpper())
            {
                if (c == ' ')
                {
                    morseSequence += " / "; // Space between words
                }
                else if (MorseCode.TryGetValue(c, out string morse))
                {
                    morseSequence += morse + " "; // Space between letters
                }
            }
            return morseSequence.Trim();
        }

        public void SendMorseSequenceAsDotAndDash(string morseSequence)
        {
            StartCoroutine(Coroutine_SendMorseSequenceAsDotAndDash(morseSequence));
        }

        private IEnumerator Coroutine_SendMorseSequenceAsDotAndDash(string morseSequence)
        {
            foreach (char c in morseSequence)
            {
                if (c == '.')
                {
                    m_arcWrapper.ToggleFlashlight();
                    yield return new WaitForSeconds(m_dotDuration); // Short pause for dot
                    m_arcWrapper.ToggleFlashlight();
                }
                else if (c == '-')
                {
                    m_arcWrapper.ToggleFlashlight();
                    yield return new WaitForSeconds(m_dashDuration); // Longer pause for dash
                    m_arcWrapper.ToggleFlashlight();

                }
                else if (c == ' ')
                {
                    yield return new WaitForSeconds(m_letterPauseDuration); // Pause between letters
                }
                else if (c == '/')
                {
                    yield return new WaitForSeconds(m_wordPauseDuration); // Pause between words
                }
            }

        }
    }
    public enum MorseSymbol
    {
        A, B, C, D, E, F, G, H, I, J,
        K, L, M, N, O, P, Q, R, S, T,
        U, V, W, X, Y, Z,

        Zero, One, Two, Three, Four,
        Five, Six, Seven, Eight, Nine,

        Period,
        Comma,
        QuestionMark,
        Apostrophe,
        Exclamation,
        Slash,
        ParenthesisOpen,
        ParenthesisClose,
        Ampersand,
        Colon,
        Semicolon,
        Equals,
        Plus,
        Hyphen,
        Underscore,
        Quotation,
        Dollar,
        At
    }

    public static class MorseCode
    {
            public static readonly Dictionary<char, string> MapChar =
                new Dictionary<char, string>
                {
                    // Letters
                    { 'A', ".-" },    { 'B', "-..." },  { 'C', "-.-." },  { 'D', "-.." },
                    { 'E', "." },     { 'F', "..-." },  { 'G', "--." },   { 'H', "...." },
                    { 'I', ".." },    { 'J', ".---" },  { 'K', "-.-" },   { 'L', ".-.." },
                    { 'M', "--" },    { 'N', "-." },    { 'O', "---" },   { 'P', ".--." },
                    { 'Q', "--.-" },  { 'R', ".-." },   { 'S', "..." },   { 'T', "-" },
                    { 'U', "..-" },   { 'V', "...-" },  { 'W', ".--" },   { 'X', "-..-" },
                    { 'Y', "-.--" },  { 'Z', "--.." },

                    // Numbers
                    { '0', "-----" },
                    { '1', ".----" },
                    { '2', "..---" },
                    { '3', "...--" },
                    { '4', "....-" },
                    { '5', "....." },
                    { '6', "-...." },
                    { '7', "--..." },
                    { '8', "---.." },
                    { '9', "----." },

                    // Punctuation
                    { '.', ".-.-.-" },
                    { ',', "--..--" },
                    { '?', "..--.." },
                    { '\'', ".----." },
                    { '!', "-.-.--" },
                    { '/', "-..-." },
                    { '(', "-.--." },
                    { ')', "-.--.-" },
                    { '&', ".-..." },
                    { ':', "---..." },
                    { ';', "-.-.-." },
                    { '=', "-...-" },
                    { '+', ".-.-." },
                    { '-', "-....-" },
                    { '_', "..--.-" },
                    { '"', ".-..-." },
                    { '$', "...-..-" },
                    { '@', ".--.-." }
                        };


        public static readonly Dictionary<MorseSymbol, string> MapEnum =
            new Dictionary<MorseSymbol, string>
            {
            // Letters
            { MorseSymbol.A, ".-" },
            { MorseSymbol.B, "-..." },
            { MorseSymbol.C, "-.-." },
            { MorseSymbol.D, "-.." },
            { MorseSymbol.E, "." },
            { MorseSymbol.F, "..-." },
            { MorseSymbol.G, "--." },
            { MorseSymbol.H, "...." },
            { MorseSymbol.I, ".." },
            { MorseSymbol.J, ".---" },
            { MorseSymbol.K, "-.-" },
            { MorseSymbol.L, ".-.." },
            { MorseSymbol.M, "--" },
            { MorseSymbol.N, "-." },
            { MorseSymbol.O, "---" },
            { MorseSymbol.P, ".--." },
            { MorseSymbol.Q, "--.-" },
            { MorseSymbol.R, ".-." },
            { MorseSymbol.S, "..." },
            { MorseSymbol.T, "-" },
            { MorseSymbol.U, "..-" },
            { MorseSymbol.V, "...-" },
            { MorseSymbol.W, ".--" },
            { MorseSymbol.X, "-..-" },
            { MorseSymbol.Y, "-.--" },
            { MorseSymbol.Z, "--.." },

            // Numbers
            { MorseSymbol.Zero, "-----" },
            { MorseSymbol.One, ".----" },
            { MorseSymbol.Two, "..---" },
            { MorseSymbol.Three, "...--" },
            { MorseSymbol.Four, "....-" },
            { MorseSymbol.Five, "....." },
            { MorseSymbol.Six, "-...." },
            { MorseSymbol.Seven, "--..." },
            { MorseSymbol.Eight, "---.." },
            { MorseSymbol.Nine, "----." },

            // Punctuation
            { MorseSymbol.Period, ".-.-.-" },
            { MorseSymbol.Comma, "--..--" },
            { MorseSymbol.QuestionMark, "..--.." },
            { MorseSymbol.Apostrophe, ".----." },
            { MorseSymbol.Exclamation, "-.-.--" },
            { MorseSymbol.Slash, "-..-." },
            { MorseSymbol.ParenthesisOpen, "-.--." },
            { MorseSymbol.ParenthesisClose, "-.--.-" },
            { MorseSymbol.Ampersand, ".-..." },
            { MorseSymbol.Colon, "---..." },
            { MorseSymbol.Semicolon, "-.-.-." },
            { MorseSymbol.Equals, "-...-" },
            { MorseSymbol.Plus, ".-.-." },
            { MorseSymbol.Hyphen, "-....-" },
            { MorseSymbol.Underscore, "..--.-" },
            { MorseSymbol.Quotation, ".-..-." },
            { MorseSymbol.Dollar, "...-..-" },
            { MorseSymbol.At, ".--.-." }
         };

        public static bool TryGetValue(char c, out string morse)
        {
            return MapChar.TryGetValue(c, out morse);
        }
    }

}
