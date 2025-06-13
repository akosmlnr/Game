using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060A RID: 1546
	public static class ItemQuality : Il2CppSystem.Object
	{
		// Token: 0x06008611 RID: 34321 RVA: 0x0023BDF4 File Offset: 0x00239FF4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemQuality()
		{
			Il2CppClassPointerStore<ItemQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr);
			ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Threshold");
			ItemQuality.NativeFieldInfoPtr_Premium_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Threshold");
			ItemQuality.NativeFieldInfoPtr_Standard_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Threshold");
			ItemQuality.NativeFieldInfoPtr_Poor_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Threshold");
			ItemQuality.NativeFieldInfoPtr_Heavenly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Heavenly_Color");
			ItemQuality.NativeFieldInfoPtr_Premium_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Premium_Color");
			ItemQuality.NativeFieldInfoPtr_Standard_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Standard_Color");
			ItemQuality.NativeFieldInfoPtr_Poor_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Poor_Color");
			ItemQuality.NativeFieldInfoPtr_Trash_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, "Trash_Color");
			ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100680164);
			ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemQuality>.NativeClassPtr, 100680165);
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x0023BF00 File Offset: 0x0023A100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251551, RefRangeEnd = 251553, XrefRangeStart = 251551, XrefRangeEnd = 251551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetQuality(float qualityScalar)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref qualityScalar;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x0023BF40 File Offset: 0x0023A140
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251560, RefRangeEnd = 251566, XrefRangeStart = 251553, XrefRangeEnd = 251560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(EQuality quality)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemQuality.NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x0003F68E File Offset: 0x0003D88E
		public ItemQuality(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x0023BF80 File Offset: 0x0023A180
		// (set) Token: 0x06008616 RID: 34326 RVA: 0x0003F697 File Offset: 0x0003D897
		public unsafe static float Heavenly_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Threshold, (void*)(&value));
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x0023BF9C File Offset: 0x0023A19C
		// (set) Token: 0x06008618 RID: 34328 RVA: 0x0003F6A5 File Offset: 0x0003D8A5
		public unsafe static float Premium_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Threshold, (void*)(&value));
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06008619 RID: 34329 RVA: 0x0023BFB8 File Offset: 0x0023A1B8
		// (set) Token: 0x0600861A RID: 34330 RVA: 0x0003F6B3 File Offset: 0x0003D8B3
		public unsafe static float Standard_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Threshold, (void*)(&value));
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x0023BFD4 File Offset: 0x0023A1D4
		// (set) Token: 0x0600861C RID: 34332 RVA: 0x0003F6C1 File Offset: 0x0003D8C1
		public unsafe static float Poor_Threshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Threshold, (void*)(&value));
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x0023BFF0 File Offset: 0x0023A1F0
		// (set) Token: 0x0600861E RID: 34334 RVA: 0x0003F6CF File Offset: 0x0003D8CF
		public unsafe static Color Heavenly_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Heavenly_Color, (void*)(&value));
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600861F RID: 34335 RVA: 0x0023C00C File Offset: 0x0023A20C
		// (set) Token: 0x06008620 RID: 34336 RVA: 0x0003F6DD File Offset: 0x0003D8DD
		public unsafe static Color Premium_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Premium_Color, (void*)(&value));
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x0023C028 File Offset: 0x0023A228
		// (set) Token: 0x06008622 RID: 34338 RVA: 0x0003F6EB File Offset: 0x0003D8EB
		public unsafe static Color Standard_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Standard_Color, (void*)(&value));
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x06008623 RID: 34339 RVA: 0x0023C044 File Offset: 0x0023A244
		// (set) Token: 0x06008624 RID: 34340 RVA: 0x0003F6F9 File Offset: 0x0003D8F9
		public unsafe static Color Poor_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Poor_Color, (void*)(&value));
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06008625 RID: 34341 RVA: 0x0023C060 File Offset: 0x0023A260
		// (set) Token: 0x06008626 RID: 34342 RVA: 0x0003F707 File Offset: 0x0003D907
		public unsafe static Color Trash_Color
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemQuality.NativeFieldInfoPtr_Trash_Color, (void*)(&value));
			}
		}

		// Token: 0x04005B4D RID: 23373
		private static readonly System.IntPtr NativeFieldInfoPtr_Heavenly_Threshold;

		// Token: 0x04005B4E RID: 23374
		private static readonly System.IntPtr NativeFieldInfoPtr_Premium_Threshold;

		// Token: 0x04005B4F RID: 23375
		private static readonly System.IntPtr NativeFieldInfoPtr_Standard_Threshold;

		// Token: 0x04005B50 RID: 23376
		private static readonly System.IntPtr NativeFieldInfoPtr_Poor_Threshold;

		// Token: 0x04005B51 RID: 23377
		private static readonly System.IntPtr NativeFieldInfoPtr_Heavenly_Color;

		// Token: 0x04005B52 RID: 23378
		private static readonly System.IntPtr NativeFieldInfoPtr_Premium_Color;

		// Token: 0x04005B53 RID: 23379
		private static readonly System.IntPtr NativeFieldInfoPtr_Standard_Color;

		// Token: 0x04005B54 RID: 23380
		private static readonly System.IntPtr NativeFieldInfoPtr_Poor_Color;

		// Token: 0x04005B55 RID: 23381
		private static readonly System.IntPtr NativeFieldInfoPtr_Trash_Color;

		// Token: 0x04005B56 RID: 23382
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuality_Public_Static_EQuality_Single_0;

		// Token: 0x04005B57 RID: 23383
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EQuality_0;
	}
}
