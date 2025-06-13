using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AA RID: 682
	[System.Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06003185 RID: 12677 RVA: 0x001117E8 File Offset: 0x0010F9E8
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeData()
		{
			Il2CppClassPointerStore<EmployeeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "EmployeeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr);
			EmployeeData.NativeFieldInfoPtr_AssignedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AssignedProperty");
			EmployeeData.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "FirstName");
			EmployeeData.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "LastName");
			EmployeeData.NativeFieldInfoPtr_IsMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "IsMale");
			EmployeeData.NativeFieldInfoPtr_AppearanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AppearanceIndex");
			EmployeeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Position");
			EmployeeData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Rotation");
			EmployeeData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "GUID");
			EmployeeData.NativeFieldInfoPtr_PaidForToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "PaidForToday");
			EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, 100669048);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x001118E0 File Offset: 0x0010FAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136872, RefRangeEnd = 136873, XrefRangeStart = 136865, XrefRangeEnd = 136872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Il2CppSystem.Guid guid, bool paidForToday) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref isMale;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref guid;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref paidForToday;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0001A096 File Offset: 0x00018296
		public EmployeeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x001119B8 File Offset: 0x0010FBB8
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0001A09F File Offset: 0x0001829F
		public unsafe string AssignedProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x001119E0 File Offset: 0x0010FBE0
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x0001A0BE File Offset: 0x000182BE
		public unsafe string FirstName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x00111A08 File Offset: 0x0010FC08
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x0001A0DD File Offset: 0x000182DD
		public unsafe string LastName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00111A30 File Offset: 0x0010FC30
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0001A0FC File Offset: 0x000182FC
		public unsafe bool IsMale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale)) = value;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x00111A58 File Offset: 0x0010FC58
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x0001A117 File Offset: 0x00018317
		public unsafe int AppearanceIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex)) = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x00111A80 File Offset: 0x0010FC80
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x0001A132 File Offset: 0x00018332
		public unsafe Vector3 Position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00111AA8 File Offset: 0x0010FCA8
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x0001A14D File Offset: 0x0001834D
		public unsafe Quaternion Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x00111AD0 File Offset: 0x0010FCD0
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0001A168 File Offset: 0x00018368
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x00111AF8 File Offset: 0x0010FCF8
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x0001A187 File Offset: 0x00018387
		public unsafe bool PaidForToday
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday)) = value;
			}
		}

		// Token: 0x04002077 RID: 8311
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedProperty;

		// Token: 0x04002078 RID: 8312
		private static readonly System.IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x04002079 RID: 8313
		private static readonly System.IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x0400207A RID: 8314
		private static readonly System.IntPtr NativeFieldInfoPtr_IsMale;

		// Token: 0x0400207B RID: 8315
		private static readonly System.IntPtr NativeFieldInfoPtr_AppearanceIndex;

		// Token: 0x0400207C RID: 8316
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400207D RID: 8317
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400207E RID: 8318
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400207F RID: 8319
		private static readonly System.IntPtr NativeFieldInfoPtr_PaidForToday;

		// Token: 0x04002080 RID: 8320
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0;
	}
}
