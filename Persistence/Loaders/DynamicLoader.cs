using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000236 RID: 566
	public class DynamicLoader : Il2CppSystem.Object
	{
		// Token: 0x06002E8F RID: 11919 RVA: 0x00107614 File Offset: 0x00105814
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicLoader()
		{
			Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "DynamicLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr);
			DynamicLoader.NativeMethodInfoPtr_Load_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100668672);
			DynamicLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100668673);
			DynamicLoader.NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100668674);
			DynamicLoader.NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100668675);
			DynamicLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr, 100668676);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x001076A8 File Offset: 0x001058A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131098, XrefRangeEnd = 131116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(string serializedDynamicSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedDynamicSaveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.NativeMethodInfoPtr_Load_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x001076EC File Offset: 0x001058EC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x0010773C File Offset: 0x0010593C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131128, RefRangeEnd = 131130, XrefRangeStart = 131116, XrefRangeEnd = 131128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ExtractBaseData<T>(DynamicSaveData saveData) where T : SaveData
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.MethodInfoStoreGeneric_ExtractBaseData_Public_Static_T_DynamicSaveData_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x0010777C File Offset: 0x0010597C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131135, RefRangeEnd = 131139, XrefRangeStart = 131130, XrefRangeEnd = 131135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryExtractBaseData<T>(DynamicSaveData saveData, out T baseData) where T : SaveData
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			System.IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref baseData;
			}
			ptr2 = intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.MethodInfoStoreGeneric_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			if (!typeof(T).IsValueType)
			{
				System.IntPtr intPtr3 = intPtr;
				baseData = ((intPtr3 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x0010780C File Offset: 0x00105A0C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00018D7D File Offset: 0x00016F7D
		public DynamicLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EE4 RID: 7908
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_String_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly System.IntPtr NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly System.IntPtr NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092E RID: 2350
		private sealed class MethodInfoStoreGeneric_ExtractBaseData_Public_Static_T_DynamicSaveData_0<T>
		{
			// Token: 0x040088EE RID: 35054
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicLoader.NativeMethodInfoPtr_ExtractBaseData_Public_Static_T_DynamicSaveData_0, Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200092F RID: 2351
		private sealed class MethodInfoStoreGeneric_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0<T>
		{
			// Token: 0x040088EF RID: 35055
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicLoader.NativeMethodInfoPtr_TryExtractBaseData_Public_Static_Boolean_DynamicSaveData_byref_T_0, Il2CppClassPointerStore<DynamicLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
