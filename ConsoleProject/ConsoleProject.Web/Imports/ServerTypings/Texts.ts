namespace ConsoleProject.Texts {

    declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Common {

            namespace UserPreference {
                export const Name: string;
                export const PreferenceType: string;
                export const UserId: string;
                export const UserPreferenceId: string;
                export const Value: string;
            }
        }

        namespace Default {

            namespace BatchTbl {
                export const BatchDays: string;
                export const BatchId: string;
                export const BatchName: string;
                export const BatchTime: string;
                export const IsActive: string;
                export const LookupText: string;
            }

            namespace ExamResult {
                export const BatchBatchDays: string;
                export const BatchBatchName: string;
                export const BatchBatchTime: string;
                export const BatchId: string;
                export const ChapterNo: string;
                export const ExamDate: string;
                export const ExamMark: string;
                export const ExamType: string;
                export const ExamTypeExamName: string;
                export const HeightMark: string;
                export const ObatainedMark: string;
                export const ResultId: string;
                export const StudentAddress: string;
                export const StudentAdmissionDate: string;
                export const StudentAdmissionType: string;
                export const StudentBatchTime: string;
                export const StudentCollegeBatch: string;
                export const StudentCollegeName: string;
                export const StudentCourseDuration: string;
                export const StudentCourseTotalFee: string;
                export const StudentDays: string;
                export const StudentDescription: string;
                export const StudentEntryDate: string;
                export const StudentEntryUser: string;
                export const StudentFatherName: string;
                export const StudentFatherPhone: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentIsActive: string;
                export const StudentLeftDate: string;
                export const StudentMonthlyFee: string;
                export const StudentMotherName: string;
                export const StudentMotherPhone: string;
                export const StudentName: string;
                export const StudentPersonalPhone: string;
                export const StudentUserImage: string;
                export const TotalMark: string;
            }

            namespace ExamType {
                export const ExamId: string;
                export const ExamName: string;
            }

            namespace PaymentInfoTbl {
                export const Amount: string;
                export const EntryDate: string;
                export const EntryUser: string;
                export const PaymentDate: string;
                export const PaymentId: string;
                export const StudentAddress: string;
                export const StudentAdmissionDate: string;
                export const StudentAdmissionType: string;
                export const StudentCollegeBatch: string;
                export const StudentCollegeName: string;
                export const StudentCourseDuration: string;
                export const StudentCourseTotalFee: string;
                export const StudentDescription: string;
                export const StudentEntryDate: string;
                export const StudentEntryUser: string;
                export const StudentFatherName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentIsActive: string;
                export const StudentLeftDate: string;
                export const StudentMonthlyFee: string;
                export const StudentMotherName: string;
                export const StudentName: string;
                export const StudentUserImage: string;
            }

            namespace StudentInfoTbl {
                export const Address: string;
                export const AdmissionDate: string;
                export const AdmissionType: string;
                export const BatchBatchDays: string;
                export const BatchBatchName: string;
                export const BatchBatchTime: string;
                export const BatchId: string;
                export const BatchIsActive: string;
                export const CollegeBatch: string;
                export const CollegeName: string;
                export const CourseDuration: string;
                export const CourseTotalFee: string;
                export const Description: string;
                export const EntryDate: string;
                export const EntryUser: string;
                export const FatherName: string;
                export const FatherPhone: string;
                export const Gender: string;
                export const IsActive: string;
                export const LeftDate: string;
                export const LookupText: string;
                export const MonthlyFee: string;
                export const MotherName: string;
                export const MotherPhone: string;
                export const Name: string;
                export const PersonalPhone: string;
                export const StudentAddress: string;
                export const StudentAdmissionDate: string;
                export const StudentAdmissionType: string;
                export const StudentBatchId: string;
                export const StudentCollegeBatch: string;
                export const StudentCollegeName: string;
                export const StudentCourseDuration: string;
                export const StudentCourseTotalFee: string;
                export const StudentDepartment: string;
                export const StudentDescription: string;
                export const StudentEntryDate: string;
                export const StudentEntryUser: string;
                export const StudentFatherName: string;
                export const StudentFatherPhone: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentIsActive: string;
                export const StudentLeftDate: string;
                export const StudentMonthlyFee: string;
                export const StudentMotherName: string;
                export const StudentMotherPhone: string;
                export const StudentName: string;
                export const StudentPersonalPhone: string;
                export const StudentStatus: string;
                export const StudentUserImage: string;
                export const UserImage: string;
            }

            namespace VisitorTbl {
                export const Address: string;
                export const CollegeBatch: string;
                export const CollegeName: string;
                export const Email: string;
                export const FatherName: string;
                export const MotherName: string;
                export const Name: string;
                export const Notes: string;
                export const ParentsContact: string;
                export const PersonalContact: string;
                export const VisitDate: string;
                export const VisitorId: string;
            }
        }

        namespace _Ext {

            namespace AuditLog {
                export const ActionDate: string;
                export const ActionType: string;
                export const EntityId: string;
                export const EntityTableName: string;
                export const Id: string;
                export const IpAddress: string;
                export const NewEntity: string;
                export const OldEntity: string;
                export const SessionId: string;
                export const UserId: string;
                export const VersionNo: string;
            }
        }
    }

    declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const FormTitle: string;
                export const GoogleButton: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    declare namespace Validation {
        export const AuthenticationError: string;
        export const CantFindUserWithEmail: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const SavePrimaryKeyError: string;
    }

    ConsoleProject['Texts'] = Q.proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Common:{UserPreference:{Name:1,PreferenceType:1,UserId:1,UserPreferenceId:1,Value:1}},Default:{BatchTbl:{BatchDays:1,BatchId:1,BatchName:1,BatchTime:1,IsActive:1,LookupText:1},ExamResult:{BatchBatchDays:1,BatchBatchName:1,BatchBatchTime:1,BatchId:1,ChapterNo:1,ExamDate:1,ExamMark:1,ExamType:1,ExamTypeExamName:1,HeightMark:1,ObatainedMark:1,ResultId:1,StudentAddress:1,StudentAdmissionDate:1,StudentAdmissionType:1,StudentBatchTime:1,StudentCollegeBatch:1,StudentCollegeName:1,StudentCourseDuration:1,StudentCourseTotalFee:1,StudentDays:1,StudentDescription:1,StudentEntryDate:1,StudentEntryUser:1,StudentFatherName:1,StudentFatherPhone:1,StudentGender:1,StudentId:1,StudentIsActive:1,StudentLeftDate:1,StudentMonthlyFee:1,StudentMotherName:1,StudentMotherPhone:1,StudentName:1,StudentPersonalPhone:1,StudentUserImage:1,TotalMark:1},ExamType:{ExamId:1,ExamName:1},PaymentInfoTbl:{Amount:1,EntryDate:1,EntryUser:1,PaymentDate:1,PaymentId:1,StudentAddress:1,StudentAdmissionDate:1,StudentAdmissionType:1,StudentCollegeBatch:1,StudentCollegeName:1,StudentCourseDuration:1,StudentCourseTotalFee:1,StudentDescription:1,StudentEntryDate:1,StudentEntryUser:1,StudentFatherName:1,StudentGender:1,StudentId:1,StudentIsActive:1,StudentLeftDate:1,StudentMonthlyFee:1,StudentMotherName:1,StudentName:1,StudentUserImage:1},StudentInfoTbl:{Address:1,AdmissionDate:1,AdmissionType:1,BatchBatchDays:1,BatchBatchName:1,BatchBatchTime:1,BatchId:1,BatchIsActive:1,CollegeBatch:1,CollegeName:1,CourseDuration:1,CourseTotalFee:1,Description:1,EntryDate:1,EntryUser:1,FatherName:1,FatherPhone:1,Gender:1,IsActive:1,LeftDate:1,LookupText:1,MonthlyFee:1,MotherName:1,MotherPhone:1,Name:1,PersonalPhone:1,StudentAddress:1,StudentAdmissionDate:1,StudentAdmissionType:1,StudentBatchId:1,StudentCollegeBatch:1,StudentCollegeName:1,StudentCourseDuration:1,StudentCourseTotalFee:1,StudentDepartment:1,StudentDescription:1,StudentEntryDate:1,StudentEntryUser:1,StudentFatherName:1,StudentFatherPhone:1,StudentGender:1,StudentId:1,StudentIsActive:1,StudentLeftDate:1,StudentMonthlyFee:1,StudentMotherName:1,StudentMotherPhone:1,StudentName:1,StudentPersonalPhone:1,StudentStatus:1,StudentUserImage:1,UserImage:1},VisitorTbl:{Address:1,CollegeBatch:1,CollegeName:1,Email:1,FatherName:1,MotherName:1,Name:1,Notes:1,ParentsContact:1,PersonalContact:1,VisitDate:1,VisitorId:1}},_Ext:{AuditLog:{ActionDate:1,ActionType:1,EntityId:1,EntityTableName:1,Id:1,IpAddress:1,NewEntity:1,OldEntity:1,SessionId:1,UserId:1,VersionNo:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,Success:1},Login:{FacebookButton:1,ForgotPassword:1,FormTitle:1,GoogleButton:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CantFindUserWithEmail:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,SavePrimaryKeyError:1}});
}

