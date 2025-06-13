using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022C RID: 556
	public class LoadRequest : Il2CppSystem.Object
	{
		// Token: 0x06002DE1 RID: 11745 RVA: 0x00105420 File Offset: 0x00103620
		// Note: this type is marked as 'beforefieldinit'.
		static LoadRequest()
		{
			Il2CppClassPointerStore<LoadRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr);
			LoadRequest.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Path");
			LoadRequest.NativeFieldInfoPtr_Loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Loader");
			LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "<IsDone>k__BackingField");
			LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668600);
			LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668601);
			LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668602);
			LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668603);
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x001054DC File Offset: 0x001036DC
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x00105518 File Offset: 0x00103718
		public unsafe bool IsDone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00105558 File Offset: 0x00103758
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130152, RefRangeEnd = 130160, XrefRangeStart = 130132, XrefRangeEnd = 130152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadRequest(string filePath, Loader loader) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x001055B8 File Offset: 0x001037B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130160, XrefRangeEnd = 130167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0001887B File Offset: 0x00016A7B
		public LoadRequest(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x001055EC File Offset: 0x001037EC
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x00018884 File Offset: 0x00016A84
		public unsafe string Path
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x00105614 File Offset: 0x00103814
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x000188A3 File Offset: 0x00016AA3
		public unsafe Loader Loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x00105644 File Offset: 0x00103844
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x000188C2 File Offset: 0x00016AC2
		public unsafe bool _IsDone_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField)) = value;
			}
		}

		// Token: 0x04001E77 RID: 7799
		private static readonly System.IntPtr NativeFieldInfoPtr_Path;

		// Token: 0x04001E78 RID: 7800
		private static readonly System.IntPtr NativeFieldInfoPtr_Loader;

		// Token: 0x04001E79 RID: 7801
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDone_k__BackingField;

		// Token: 0x04001E7A RID: 7802
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
