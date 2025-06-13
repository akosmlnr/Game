using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000231 RID: 561
	public class SaveRequest : Il2CppSystem.Object
	{
		// Token: 0x06002E71 RID: 11889 RVA: 0x00106F7C File Offset: 0x0010517C
		// Note: this type is marked as 'beforefieldinit'.
		static SaveRequest()
		{
			Il2CppClassPointerStore<SaveRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr);
			SaveRequest.NativeFieldInfoPtr_Saveable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "Saveable");
			SaveRequest.NativeFieldInfoPtr_ParentFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "ParentFolderPath");
			SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "<SaveString>k__BackingField");
			SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668658);
			SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668659);
			SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668660);
			SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668661);
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x00107038 File Offset: 0x00105238
		// (set) Token: 0x06002E73 RID: 11891 RVA: 0x00107070 File Offset: 0x00105270
		public unsafe string SaveString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x001070B4 File Offset: 0x001052B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 130913, RefRangeEnd = 130920, XrefRangeStart = 130900, XrefRangeEnd = 130913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest(ISaveable saveable, string parentFolderPath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00107114 File Offset: 0x00105314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130932, RefRangeEnd = 130933, XrefRangeStart = 130920, XrefRangeEnd = 130932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00018CF3 File Offset: 0x00016EF3
		public SaveRequest(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00107148 File Offset: 0x00105348
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00018CFC File Offset: 0x00016EFC
		public unsafe ISaveable Saveable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISaveable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x00107178 File Offset: 0x00105378
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x00018D1B File Offset: 0x00016F1B
		public unsafe string ParentFolderPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x001071A0 File Offset: 0x001053A0
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x00018D3A File Offset: 0x00016F3A
		public unsafe string _SaveString_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001ED3 RID: 7891
		private static readonly System.IntPtr NativeFieldInfoPtr_Saveable;

		// Token: 0x04001ED4 RID: 7892
		private static readonly System.IntPtr NativeFieldInfoPtr_ParentFolderPath;

		// Token: 0x04001ED5 RID: 7893
		private static readonly System.IntPtr NativeFieldInfoPtr__SaveString_k__BackingField;

		// Token: 0x04001ED6 RID: 7894
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveString_Public_get_String_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0;

		// Token: 0x04001ED8 RID: 7896
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0;

		// Token: 0x04001ED9 RID: 7897
		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
