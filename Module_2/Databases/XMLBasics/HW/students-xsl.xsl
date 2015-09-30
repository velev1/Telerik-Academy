<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:students="urn:students"
                xmlns:exams="urn:exams"
                >
  <xsl:template match="/">
    <html>
      <head>
        <style>
          body{
          font-family: arial
          }
          td, td, tr, table {
          vertical-align: top;
          text-align: center;
          }

          td {
          padding: 5px;
          }

          td table {
          width: 100%;
          }

        </style>
      </head>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1" >
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Sex</b>
            </td>
            <td>
              <b>Birth date</b>
            </td>
            <td>
              <b>Phone</b>
            </td>           
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>specialty</b>
            </td>
            <td>
              <b>faculty-number</b>
            </td>
            <td>
              <b>exams</b>
            </td>
            <td>
              <b>enrollment</b>
            </td>
            <td>
              <b>endorsements</b>
            </td>
          </tr>
          <xsl:for-each select="/students:students/students:student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="students:name"/>
              </td>
              <td>
                <xsl:value-of select="students:sex"/>
              </td>
              <td>
                <date><xsl:value-of select="students:birth-date"/>
                </date>
              </td>
              <td>
                <xsl:value-of select="students:phone"/>
              </td>             
              <td>
                <xsl:value-of select="students:email"/>
              </td>
              <td>
                <xsl:value-of select="students:course"/>
              </td>
              <td>
                <xsl:value-of select="students:specialty"/>
              </td>
              <td>
                <xsl:value-of select="students:faculty-number"/>
              </td>
              <td>
                <table bgcolor="#E0E0E0" cellspacing="1" >
                  <tr bgcolor="#EEEEEE">
                    <td>name</td>
                    <td>tutor</td>
                    <td>score</td>
                  </tr>
                <xsl:for-each select="students:exams/exams:exam">
                  <tr  bgcolor="white">
                    <td>
                      <xsl:value-of select="exams:name"/>
                    </td>
                    <td>
                      <xsl:value-of select="exams:tutor"/>
                    </td>
                    <td>
                      <xsl:value-of select="exams:score"/>
                    </td>
                  </tr>
                  </xsl:for-each>
                </table>
              </td>
              <td>
                <table bgcolor="#E0E0E0" cellspacing="1" >
                  <tr bgcolor="#EEEEEE">
                    <td>date</td>
                    <td>score</td>
                  </tr>                
                    <tr  bgcolor="white">
                      <td>
                        <xsl:value-of select="students:enrollment/students:date"/>
                      </td>
                      <td>
                        <xsl:value-of select="students:enrollment/students:score"/>
                      </td>
                    </tr>
                 
                </table>
              </td>
              <td>
                <table bgcolor="#E0E0E0" cellspacing="1" >
                  <tr bgcolor="#EEEEEE">
                    <td>teacher</td>
                    <td>text</td>
                  </tr>
                  <xsl:for-each select="students:endorsements/students:endorsement">
                    <tr  bgcolor="white">
                      <td>
                        <xsl:value-of select="students:teacher"/>
                      </td>
                      <td>
                        <xsl:value-of select="students:text"/>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
