using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000247 RID: 583
	public class ShopManagerLoader : Loader
	{
		// Token: 0x06002EDF RID: 11999 RVA: 0x00108A7C File Offset: 0x00106C7C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopManagerLoader()
		{
			Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ShopManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr);
			ShopManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr, 100668731);
			ShopManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr, 100668732);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00108AD4 File Offset: 0x00106CD4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00108B10 File Offset: 0x00106D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132082, XrefRangeEnd = 132147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00018E16 File Offset: 0x00017016
		public ShopManagerLoader(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F12 RID: 7954
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000934 RID: 2356
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ShopManagerLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9EE RID: 51694 RVA: 0x00314738 File Offset: 0x00312938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr);
				ShopManagerLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_shopData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr, "shopData");
				ShopManagerLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668733);
				ShopManagerLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668734);
			}

			// Token: 0x0600C9EF RID: 51695 RVA: 0x003147A0 File Offset: 0x003129A0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopManagerLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopManagerLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9F0 RID: 51696 RVA: 0x003147DC File Offset: 0x003129DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopManagerLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C9F1 RID: 51697 RVA: 0x00061E92 File Offset: 0x00060092
			public __c__DisplayClass1_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB6 RID: 16054
			// (get) Token: 0x0600C9F2 RID: 51698 RVA: 0x0031482C File Offset: 0x00312A2C
			// (set) Token: 0x0600C9F3 RID: 51699 RVA: 0x00061E9B File Offset: 0x0006009B
			public unsafe ShopData shopData
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_shopData);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_shopData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088FB RID: 35067
			private static readonly System.IntPtr NativeFieldInfoPtr_shopData;

			// Token: 0x040088FC RID: 35068
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088FD RID: 35069
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
