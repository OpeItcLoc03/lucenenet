﻿namespace org.apache.lucene.analysis.standard
{

	/*
	 * Licensed to the Apache Software Foundation (ASF) under one or more
	 * contributor license agreements.  See the NOTICE file distributed with
	 * this work for additional information regarding copyright ownership.
	 * The ASF licenses this file to You under the Apache License, Version 2.0
	 * (the "License"); you may not use this file except in compliance with
	 * the License.  You may obtain a copy of the License at
	 *
	 *     http://www.apache.org/licenses/LICENSE-2.0
	 *
	 * Unless required by applicable law or agreed to in writing, software
	 * distributed under the License is distributed on an "AS IS" BASIS,
	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	 * See the License for the specific language governing permissions and
	 * limitations under the License.
	 */

	using CharTermAttribute = org.apache.lucene.analysis.tokenattributes.CharTermAttribute;


	/// <summary>
	/// Internal interface for supporting versioned grammars.
	/// @lucene.internal 
	/// </summary>
	public interface StandardTokenizerInterface
	{

	  /// <summary>
	  /// This character denotes the end of file </summary>

	  /// <summary>
	  /// Copies the matched text into the CharTermAttribute
	  /// </summary>
	  void getText(CharTermAttribute t);

	  /// <summary>
	  /// Returns the current position.
	  /// </summary>
	  int yychar();

	  /// <summary>
	  /// Resets the scanner to read from a new input stream.
	  /// Does not close the old reader.
	  /// 
	  /// All internal variables are reset, the old input stream 
	  /// <b>cannot</b> be reused (internal buffer is discarded and lost).
	  /// Lexical state is set to <tt>ZZ_INITIAL</tt>.
	  /// </summary>
	  /// <param name="reader">   the new input stream  </param>
	  void yyreset(Reader reader);

	  /// <summary>
	  /// Returns the length of the matched text region.
	  /// </summary>
	  int yylength();

	  /// <summary>
	  /// Resumes scanning until the next regular expression is matched,
	  /// the end of input is encountered or an I/O-Error occurs.
	  /// </summary>
	  /// <returns>      the next token, <seealso cref="#YYEOF"/> on end of stream </returns>
	  /// <exception cref="IOException">  if any I/O-Error occurs </exception>
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int getNextToken() throws java.io.IOException;
	  int NextToken {get;}

	}

	public static class StandardTokenizerInterface_Fields
	{
	  public const int YYEOF = -1;
	}

}