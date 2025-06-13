using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A0 RID: 672
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x0600312E RID: 12590 RVA: 0x0011080C File Offset: 0x0010EA0C
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_CreationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationDate");
			MetaData.NativeFieldInfoPtr_LastPlayedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastPlayedDate");
			MetaData.NativeFieldInfoPtr_CreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationVersion");
			MetaData.NativeFieldInfoPtr_LastSaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastSaveVersion");
			MetaData.NativeFieldInfoPtr_PlayTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "PlayTutorial");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100669037);
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x001108B4 File Offset: 0x0010EAB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136827, RefRangeEnd = 136831, XrefRangeStart = 136822, XrefRangeEnd = 136827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(creationDate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastPlayedDate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(creationVersion);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastSaveVersion);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playTutorial;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00019D10 File Offset: 0x00017F10
		public MetaData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x00110944 File Offset: 0x0010EB44
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00019D19 File Offset: 0x00017F19
		public unsafe DateTimeData CreationDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x00110974 File Offset: 0x0010EB74
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x00019D38 File Offset: 0x00017F38
		public unsafe DateTimeData LastPlayedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x001109A4 File Offset: 0x0010EBA4
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x00019D57 File Offset: 0x00017F57
		public unsafe string CreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x001109CC File Offset: 0x0010EBCC
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x00019D76 File Offset: 0x00017F76
		public unsafe string LastSaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x001109F4 File Offset: 0x0010EBF4
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x00019D95 File Offset: 0x00017F95
		public unsafe bool PlayTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial)) = value;
			}
		}

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeFieldInfoPtr_CreationDate;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedDate;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr_CreationVersion;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeFieldInfoPtr_LastSaveVersion;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeFieldInfoPtr_PlayTutorial;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0;
	}
}
