using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047E RID: 1150
	public class MetadataManager : Singleton<MetadataManager>
	{
		// Token: 0x060062BB RID: 25275 RVA: 0x001C4BC0 File Offset: 0x001C2DC0
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataManager()
		{
			Il2CppClassPointerStore<MetadataManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "MetadataManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr);
			MetadataManager.NativeFieldInfoPtr__CreationDate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "<CreationDate>k__BackingField");
			MetadataManager.NativeFieldInfoPtr__CreationVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "<CreationVersion>k__BackingField");
			MetadataManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "loader");
			MetadataManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MetadataManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MetadataManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			MetadataManager.NativeMethodInfoPtr_get_CreationDate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675947);
			MetadataManager.NativeMethodInfoPtr_set_CreationDate_Protected_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675948);
			MetadataManager.NativeMethodInfoPtr_get_CreationVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675949);
			MetadataManager.NativeMethodInfoPtr_set_CreationVersion_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675950);
			MetadataManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675951);
			MetadataManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675952);
			MetadataManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675953);
			MetadataManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675954);
			MetadataManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675955);
			MetadataManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675956);
			MetadataManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675957);
			MetadataManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675958);
			MetadataManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675959);
			MetadataManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675960);
			MetadataManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675961);
			MetadataManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675962);
			MetadataManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675963);
			MetadataManager.NativeMethodInfoPtr_Load_Public_Void_MetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675964);
			MetadataManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr, 100675965);
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x001C4DE4 File Offset: 0x001C2FE4
		// (set) Token: 0x060062BD RID: 25277 RVA: 0x001C4E20 File Offset: 0x001C3020
		public unsafe Il2CppSystem.DateTime CreationDate
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_CreationDate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 204107, RefRangeEnd = 204108, XrefRangeStart = 204107, XrefRangeEnd = 204107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_set_CreationDate_Protected_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x060062BE RID: 25278 RVA: 0x001C4E60 File Offset: 0x001C3060
		// (set) Token: 0x060062BF RID: 25279 RVA: 0x001C4E98 File Offset: 0x001C3098
		public unsafe string CreationVersion
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_CreationVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_set_CreationVersion_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x060062C0 RID: 25280 RVA: 0x001C4EDC File Offset: 0x001C30DC
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204108, XrefRangeEnd = 204110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x060062C1 RID: 25281 RVA: 0x001C4F14 File Offset: 0x001C3114
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204110, XrefRangeEnd = 204112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x060062C2 RID: 25282 RVA: 0x001C4F4C File Offset: 0x001C314C
		public unsafe virtual Loader Loader
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x001C4F8C File Offset: 0x001C318C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x060062C4 RID: 25284 RVA: 0x001C4FC8 File Offset: 0x001C31C8
		// (set) Token: 0x060062C5 RID: 25285 RVA: 0x001C5008 File Offset: 0x001C3208
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x060062C6 RID: 25286 RVA: 0x001C504C File Offset: 0x001C324C
		// (set) Token: 0x060062C7 RID: 25287 RVA: 0x001C508C File Offset: 0x001C328C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x001C50D0 File Offset: 0x001C32D0
		// (set) Token: 0x060062C9 RID: 25289 RVA: 0x001C510C File Offset: 0x001C330C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x001C514C File Offset: 0x001C334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204112, XrefRangeEnd = 204123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MetadataManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x001C5188 File Offset: 0x001C3388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204123, XrefRangeEnd = 204129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MetadataManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x001C51C4 File Offset: 0x001C33C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204129, XrefRangeEnd = 204149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MetadataManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x001C5208 File Offset: 0x001C3408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204151, RefRangeEnd = 204152, XrefRangeStart = 204149, XrefRangeEnd = 204151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MetaData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr_Load_Public_Void_MetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x001C524C File Offset: 0x001C344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204152, XrefRangeEnd = 204175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x0002E739 File Offset: 0x0002C939
		public MetadataManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x001C5288 File Offset: 0x001C3488
		// (set) Token: 0x060062D1 RID: 25297 RVA: 0x0002E742 File Offset: 0x0002C942
		public unsafe Il2CppSystem.DateTime _CreationDate_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__CreationDate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__CreationDate_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x001C52B0 File Offset: 0x001C34B0
		// (set) Token: 0x060062D3 RID: 25299 RVA: 0x0002E75D File Offset: 0x0002C95D
		public unsafe string _CreationVersion_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__CreationVersion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__CreationVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x060062D4 RID: 25300 RVA: 0x001C52D8 File Offset: 0x001C34D8
		// (set) Token: 0x060062D5 RID: 25301 RVA: 0x0002E77C File Offset: 0x0002C97C
		public unsafe MetadataLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x001C5308 File Offset: 0x001C3508
		// (set) Token: 0x060062D7 RID: 25303 RVA: 0x0002E79B File Offset: 0x0002C99B
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x001C5338 File Offset: 0x001C3538
		// (set) Token: 0x060062D9 RID: 25305 RVA: 0x0002E7BA File Offset: 0x0002C9BA
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x001C5368 File Offset: 0x001C3568
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x0002E7D9 File Offset: 0x0002C9D9
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04004363 RID: 17251
		private static readonly System.IntPtr NativeFieldInfoPtr__CreationDate_k__BackingField;

		// Token: 0x04004364 RID: 17252
		private static readonly System.IntPtr NativeFieldInfoPtr__CreationVersion_k__BackingField;

		// Token: 0x04004365 RID: 17253
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004366 RID: 17254
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004367 RID: 17255
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004368 RID: 17256
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004369 RID: 17257
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CreationDate_Public_get_DateTime_0;

		// Token: 0x0400436A RID: 17258
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CreationDate_Protected_set_Void_DateTime_0;

		// Token: 0x0400436B RID: 17259
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CreationVersion_Public_get_String_0;

		// Token: 0x0400436C RID: 17260
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CreationVersion_Protected_set_Void_String_0;

		// Token: 0x0400436D RID: 17261
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400436E RID: 17262
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400436F RID: 17263
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004370 RID: 17264
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004371 RID: 17265
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004372 RID: 17266
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004373 RID: 17267
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004374 RID: 17268
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004375 RID: 17269
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004376 RID: 17270
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004377 RID: 17271
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004378 RID: 17272
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004379 RID: 17273
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400437A RID: 17274
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_MetaData_0;

		// Token: 0x0400437B RID: 17275
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
