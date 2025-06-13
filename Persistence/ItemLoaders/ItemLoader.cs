using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x020002E6 RID: 742
	public class ItemLoader : Il2CppSystem.Object
	{
		// Token: 0x060033A3 RID: 13219 RVA: 0x001179C8 File Offset: 0x00115BC8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemLoader()
		{
			Il2CppClassPointerStore<ItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.ItemLoaders", "ItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr);
			ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669124);
			ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669125);
			ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669126);
			ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr, 100669127);
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00117A48 File Offset: 0x00115C48
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137433, XrefRangeEnd = 137440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00117A8C File Offset: 0x00115C8C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 137451, RefRangeEnd = 137463, XrefRangeStart = 137440, XrefRangeEnd = 137451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00117AC8 File Offset: 0x00115CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137463, XrefRangeEnd = 137481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance LoadItem(string itemString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemLoader.NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00117B24 File Offset: 0x00115D24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 137483, RefRangeEnd = 137494, XrefRangeStart = 137481, XrefRangeEnd = 137483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T LoadData<T>(string itemString) where T : ItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ItemLoader.MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x0001B6C8 File Offset: 0x000198C8
		public ItemLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002170 RID: 8560
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04002171 RID: 8561
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002172 RID: 8562
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadItem_Public_Virtual_New_ItemInstance_String_0;

		// Token: 0x04002173 RID: 8563
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Protected_T_String_0;

		// Token: 0x02000965 RID: 2405
		private sealed class MethodInfoStoreGeneric_LoadData_Protected_T_String_0<T>
		{
			// Token: 0x040089A4 RID: 35236
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ItemLoader.NativeMethodInfoPtr_LoadData_Protected_T_String_0, Il2CppClassPointerStore<ItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
