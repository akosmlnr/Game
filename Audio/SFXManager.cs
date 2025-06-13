using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004FB RID: 1275
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06006E79 RID: 28281 RVA: 0x001EC32C File Offset: 0x001EA52C
		// Note: this type is marked as 'beforefieldinit'.
		static SFXManager()
		{
			Il2CppClassPointerStore<SFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager>.NativeClassPtr);
			SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "SQR_MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_ImpactTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactTypes");
			SFXManager.NativeFieldInfoPtr_soundPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundPool");
			SFXManager.NativeFieldInfoPtr_soundsInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundsInUse");
			SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677348);
			SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677349);
			SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677350);
			SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100677351);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x001EC410 File Offset: 0x001EA610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221316, RefRangeEnd = 221319, XrefRangeStart = 221248, XrefRangeEnd = 221316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref material;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref momentum;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x001EC46C File Offset: 0x001EA66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221319, XrefRangeEnd = 221332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x001EC4A0 File Offset: 0x001EA6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221332, XrefRangeEnd = 221342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221342, XrefRangeEnd = 221364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x00034101 File Offset: 0x00032301
		public SFXManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x001EC51C File Offset: 0x001EA71C
		// (set) Token: 0x06006E80 RID: 28288 RVA: 0x0003410A File Offset: 0x0003230A
		public unsafe static float MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006E81 RID: 28289 RVA: 0x001EC538 File Offset: 0x001EA738
		// (set) Token: 0x06006E82 RID: 28290 RVA: 0x00034118 File Offset: 0x00032318
		public unsafe static float SQR_MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x001EC554 File Offset: 0x001EA754
		// (set) Token: 0x06006E84 RID: 28292 RVA: 0x00034126 File Offset: 0x00032326
		public unsafe List<SFXManager.ImpactType> ImpactTypes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SFXManager.ImpactType>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x001EC584 File Offset: 0x001EA784
		// (set) Token: 0x06006E86 RID: 28294 RVA: 0x00034145 File Offset: 0x00032345
		public unsafe List<AudioSourceController> soundPool
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x001EC5B4 File Offset: 0x001EA7B4
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x00034164 File Offset: 0x00032364
		public unsafe List<AudioSourceController> soundsInUse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B88 RID: 19336
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PLAYER_DISTANCE;

		// Token: 0x04004B89 RID: 19337
		private static readonly System.IntPtr NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE;

		// Token: 0x04004B8A RID: 19338
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactTypes;

		// Token: 0x04004B8B RID: 19339
		private static readonly System.IntPtr NativeFieldInfoPtr_soundPool;

		// Token: 0x04004B8C RID: 19340
		private static readonly System.IntPtr NativeFieldInfoPtr_soundsInUse;

		// Token: 0x04004B8D RID: 19341
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0;

		// Token: 0x04004B8E RID: 19342
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004B8F RID: 19343
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x04004B90 RID: 19344
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AAE RID: 2734
		[System.Serializable]
		public class ImpactType : Il2CppSystem.Object
		{
			// Token: 0x0600D5E2 RID: 54754 RVA: 0x00336680 File Offset: 0x00334880
			// Note: this type is marked as 'beforefieldinit'.
			static ImpactType()
			{
				Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr);
				SFXManager.ImpactType.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Material");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Clips");
				SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, 100677352);
			}

			// Token: 0x0600D5E3 RID: 54755 RVA: 0x00336738 File Offset: 0x00334938
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImpactType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5E4 RID: 54756 RVA: 0x00067CFB File Offset: 0x00065EFB
			public ImpactType(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421E RID: 16926
			// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x00336774 File Offset: 0x00334974
			// (set) Token: 0x0600D5E6 RID: 54758 RVA: 0x00067D04 File Offset: 0x00065F04
			public unsafe ImpactSoundEntity.EMaterial Material
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material)) = value;
				}
			}

			// Token: 0x1700421F RID: 16927
			// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x0033679C File Offset: 0x0033499C
			// (set) Token: 0x0600D5E8 RID: 54760 RVA: 0x00067D1F File Offset: 0x00065F1F
			public unsafe float MinVolume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume)) = value;
				}
			}

			// Token: 0x17004220 RID: 16928
			// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x003367C4 File Offset: 0x003349C4
			// (set) Token: 0x0600D5EA RID: 54762 RVA: 0x00067D3A File Offset: 0x00065F3A
			public unsafe float MaxVolume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume)) = value;
				}
			}

			// Token: 0x17004221 RID: 16929
			// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x003367EC File Offset: 0x003349EC
			// (set) Token: 0x0600D5EC RID: 54764 RVA: 0x00067D55 File Offset: 0x00065F55
			public unsafe float MinPitch
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch)) = value;
				}
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x00336814 File Offset: 0x00334A14
			// (set) Token: 0x0600D5EE RID: 54766 RVA: 0x00067D70 File Offset: 0x00065F70
			public unsafe float MaxPitch
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch)) = value;
				}
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x0033683C File Offset: 0x00334A3C
			// (set) Token: 0x0600D5F0 RID: 54768 RVA: 0x00067D8B File Offset: 0x00065F8B
			public unsafe Il2CppReferenceArray<AudioClip> Clips
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009068 RID: 36968
			private static readonly System.IntPtr NativeFieldInfoPtr_Material;

			// Token: 0x04009069 RID: 36969
			private static readonly System.IntPtr NativeFieldInfoPtr_MinVolume;

			// Token: 0x0400906A RID: 36970
			private static readonly System.IntPtr NativeFieldInfoPtr_MaxVolume;

			// Token: 0x0400906B RID: 36971
			private static readonly System.IntPtr NativeFieldInfoPtr_MinPitch;

			// Token: 0x0400906C RID: 36972
			private static readonly System.IntPtr NativeFieldInfoPtr_MaxPitch;

			// Token: 0x0400906D RID: 36973
			private static readonly System.IntPtr NativeFieldInfoPtr_Clips;

			// Token: 0x0400906E RID: 36974
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AAF RID: 2735
		[ObfuscatedName("ScheduleOne.Audio.SFXManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5F1 RID: 54769 RVA: 0x0033686C File Offset: 0x00334A6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr);
				SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, "material");
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677353);
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677354);
			}

			// Token: 0x0600D5F2 RID: 54770 RVA: 0x003368D4 File Offset: 0x00334AD4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5F3 RID: 54771 RVA: 0x00336910 File Offset: 0x00334B10
			[CallerCount(0)]
			public unsafe bool _PlayImpactSound_b__0(SFXManager.ImpactType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D5F4 RID: 54772 RVA: 0x00067DAA File Offset: 0x00065FAA
			public __c__DisplayClass6_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004224 RID: 16932
			// (get) Token: 0x0600D5F5 RID: 54773 RVA: 0x00336960 File Offset: 0x00334B60
			// (set) Token: 0x0600D5F6 RID: 54774 RVA: 0x00067DB3 File Offset: 0x00065FB3
			public unsafe ImpactSoundEntity.EMaterial material
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material)) = value;
				}
			}

			// Token: 0x0400906F RID: 36975
			private static readonly System.IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04009070 RID: 36976
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009071 RID: 36977
			private static readonly System.IntPtr NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0;
		}
	}
}
