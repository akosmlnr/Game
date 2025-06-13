using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x02000200 RID: 512
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x0600290B RID: 10507 RVA: 0x000F5278 File Offset: 0x000F3478
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapGenerator()
		{
			Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMapGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr);
			MixerMapGenerator.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapRadius");
			MixerMapGenerator.NativeFieldInfoPtr_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapName");
			MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "BasePlateMesh");
			MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "EffectPrefab");
			MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667961);
			MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667962);
			MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667963);
			MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667964);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000F5348 File Offset: 0x000F3548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121996, XrefRangeEnd = 122002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000F537C File Offset: 0x000F357C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122002, XrefRangeEnd = 122040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEffectPrefabs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000F53B0 File Offset: 0x000F35B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122040, XrefRangeEnd = 122058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect GetEffect(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000F5400 File Offset: 0x000F3600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122058, XrefRangeEnd = 122063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00016317 File Offset: 0x00014517
		public MixerMapGenerator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000F543C File Offset: 0x000F363C
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x00016320 File Offset: 0x00014520
		public unsafe float MapRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000F5464 File Offset: 0x000F3664
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x0001633B File Offset: 0x0001453B
		public unsafe string MapName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x000F548C File Offset: 0x000F368C
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x0001635A File Offset: 0x0001455A
		public unsafe Transform BasePlateMesh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000F54BC File Offset: 0x000F36BC
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x00016379 File Offset: 0x00014579
		public unsafe Effect EffectPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B3C RID: 6972
		private static readonly System.IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x04001B3D RID: 6973
		private static readonly System.IntPtr NativeFieldInfoPtr_MapName;

		// Token: 0x04001B3E RID: 6974
		private static readonly System.IntPtr NativeFieldInfoPtr_BasePlateMesh;

		// Token: 0x04001B3F RID: 6975
		private static readonly System.IntPtr NativeFieldInfoPtr_EffectPrefab;

		// Token: 0x04001B40 RID: 6976
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200090A RID: 2314
		[ObfuscatedName("ScheduleOne.Properties.MixMaps.MixerMapGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C8AA RID: 51370 RVA: 0x00310BDC File Offset: 0x0030EDDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, "property");
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667965);
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667966);
			}

			// Token: 0x0600C8AB RID: 51371 RVA: 0x00310C44 File Offset: 0x0030EE44
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8AC RID: 51372 RVA: 0x00310C80 File Offset: 0x0030EE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121977, XrefRangeEnd = 121996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEffect_b__0(Effect effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C8AD RID: 51373 RVA: 0x000614AF File Offset: 0x0005F6AF
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E56 RID: 15958
			// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x00310CD0 File Offset: 0x0030EED0
			// (set) Token: 0x0600C8AF RID: 51375 RVA: 0x000614B8 File Offset: 0x0005F6B8
			public unsafe Property property
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008818 RID: 34840
			private static readonly System.IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04008819 RID: 34841
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400881A RID: 34842
			private static readonly System.IntPtr NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0;
		}
	}
}
