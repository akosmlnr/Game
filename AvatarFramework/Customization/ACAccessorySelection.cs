using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000635 RID: 1589
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		// Token: 0x06008B95 RID: 35733 RVA: 0x0024CD8C File Offset: 0x0024AF8C
		// Note: this type is marked as 'beforefieldinit'.
		static ACAccessorySelection()
		{
			Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAccessorySelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr);
			ACAccessorySelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680767);
			ACAccessorySelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680768);
			ACAccessorySelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680769);
			ACAccessorySelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, 100680770);
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x0024CE0C File Offset: 0x0024B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257266, XrefRangeEnd = 257269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x0024CE5C File Offset: 0x0024B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257269, XrefRangeEnd = 257281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x0024CE98 File Offset: 0x0024B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257281, XrefRangeEnd = 257302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAccessorySelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x0024CEF0 File Offset: 0x0024B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257302, XrefRangeEnd = 257305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAccessorySelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x00042655 File Offset: 0x00040855
		public ACAccessorySelection(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005ED1 RID: 24273
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0;

		// Token: 0x04005ED2 RID: 24274
		private static readonly System.IntPtr NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0;

		// Token: 0x04005ED3 RID: 24275
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0;

		// Token: 0x04005ED4 RID: 24276
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B54 RID: 2900
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACAccessorySelection+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB8B RID: 56203 RVA: 0x00346648 File Offset: 0x00344848
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACAccessorySelection>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr);
				ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, 100680771);
				ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr, 100680772);
			}

			// Token: 0x0600DB8C RID: 56204 RVA: 0x003466B0 File Offset: 0x003448B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAccessorySelection.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB8D RID: 56205 RVA: 0x003466EC File Offset: 0x003448EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssetPathIndex_b__0(Accessory x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ACAccessorySelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB8E RID: 56206 RVA: 0x0006A882 File Offset: 0x00068A82
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BB RID: 17339
			// (get) Token: 0x0600DB8F RID: 56207 RVA: 0x0034673C File Offset: 0x0034493C
			// (set) Token: 0x0600DB90 RID: 56208 RVA: 0x0006A88B File Offset: 0x00068A8B
			public unsafe string path
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACAccessorySelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093B9 RID: 37817
			private static readonly System.IntPtr NativeFieldInfoPtr_path;

			// Token: 0x040093BA RID: 37818
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093BB RID: 37819
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_Accessory_0;
		}
	}
}
