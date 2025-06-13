using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200025C RID: 604
	public class BuildableItemLoader : Loader
	{
		// Token: 0x06002F43 RID: 12099 RVA: 0x0010A2E4 File Offset: 0x001084E4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemLoader()
		{
			Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BuildableItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr);
			BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668831);
			BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668832);
			BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668833);
			BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668834);
			BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668835);
			BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100668836);
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x0010A38C File Offset: 0x0010858C
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133829, XrefRangeEnd = 133836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x0010A3D0 File Offset: 0x001085D0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 133847, RefRangeEnd = 133868, XrefRangeStart = 133836, XrefRangeEnd = 133847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0010A40C File Offset: 0x0010860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133868, XrefRangeEnd = 133880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0010A45C File Offset: 0x0010865C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133880, XrefRangeEnd = 133896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0010A4AC File Offset: 0x001086AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133899, RefRangeEnd = 133900, XrefRangeStart = 133896, XrefRangeEnd = 133899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData GetBuildableItemData(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0010A4FC File Offset: 0x001086FC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 133904, RefRangeEnd = 133922, XrefRangeStart = 133900, XrefRangeEnd = 133904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string mainPath) where T : BuildableItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00018ED3 File Offset: 0x000170D3
		public BuildableItemLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F4C RID: 8012
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04001F4D RID: 8013
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F4E RID: 8014
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Protected_T_String_0;

		// Token: 0x02000949 RID: 2377
		private sealed class MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>
		{
			// Token: 0x0400894C RID: 35148
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0, Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
