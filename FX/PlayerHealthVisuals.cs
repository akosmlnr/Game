using System;
using Il2CppBeautify.Universal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000419 RID: 1049
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06005626 RID: 22054 RVA: 0x0019532C File Offset: 0x0019352C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealthVisuals()
		{
			Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PlayerHealthVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr);
			PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "GlobalVolume");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "OuterRingCurve");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "_beautifySettings");
			PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100674105);
			PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100674106);
			PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100674107);
			PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100674108);
			PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100674109);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x0019549C File Offset: 0x0019369C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184418, XrefRangeEnd = 184487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x001954D0 File Offset: 0x001936D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184487, XrefRangeEnd = 184507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00195504 File Offset: 0x00193704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184507, XrefRangeEnd = 184514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00195538 File Offset: 0x00193738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184520, RefRangeEnd = 184521, XrefRangeStart = 184514, XrefRangeEnd = 184520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects(float newHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newHealth;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x00195578 File Offset: 0x00193778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184521, XrefRangeEnd = 184522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealthVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x000291AA File Offset: 0x000273AA
		public PlayerHealthVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x001955B4 File Offset: 0x001937B4
		// (set) Token: 0x0600562E RID: 22062 RVA: 0x000291B3 File Offset: 0x000273B3
		public unsafe Volume GlobalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_GlobalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x001955E4 File Offset: 0x001937E4
		// (set) Token: 0x06005630 RID: 22064 RVA: 0x000291D2 File Offset: 0x000273D2
		public unsafe float VignetteAlpha_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth)) = value;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x0019560C File Offset: 0x0019380C
		// (set) Token: 0x06005632 RID: 22066 RVA: 0x000291ED File Offset: 0x000273ED
		public unsafe float VignetteAlpha_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth)) = value;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x00195634 File Offset: 0x00193834
		// (set) Token: 0x06005634 RID: 22068 RVA: 0x00029208 File Offset: 0x00027408
		public unsafe AnimationCurve OuterRingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06005635 RID: 22069 RVA: 0x00195664 File Offset: 0x00193864
		// (set) Token: 0x06005636 RID: 22070 RVA: 0x00029227 File Offset: 0x00027427
		public unsafe float Saturation_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth)) = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x0019568C File Offset: 0x0019388C
		// (set) Token: 0x06005638 RID: 22072 RVA: 0x00029242 File Offset: 0x00027442
		public unsafe float Saturation_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth)) = value;
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x001956B4 File Offset: 0x001938B4
		// (set) Token: 0x0600563A RID: 22074 RVA: 0x0002925D File Offset: 0x0002745D
		public unsafe float ChromAb_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth)) = value;
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x001956DC File Offset: 0x001938DC
		// (set) Token: 0x0600563C RID: 22076 RVA: 0x00029278 File Offset: 0x00027478
		public unsafe float ChromAb_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth)) = value;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600563D RID: 22077 RVA: 0x00195704 File Offset: 0x00193904
		// (set) Token: 0x0600563E RID: 22078 RVA: 0x00029293 File Offset: 0x00027493
		public unsafe float LensDirt_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth)) = value;
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x0019572C File Offset: 0x0019392C
		// (set) Token: 0x06005640 RID: 22080 RVA: 0x000292AE File Offset: 0x000274AE
		public unsafe float LensDirt_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth)) = value;
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x00195754 File Offset: 0x00193954
		// (set) Token: 0x06005642 RID: 22082 RVA: 0x000292C9 File Offset: 0x000274C9
		public unsafe Beautify _beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beautify>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeFieldInfoPtr_GlobalVolume;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MaxHealth;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MinHealth;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeFieldInfoPtr_OuterRingCurve;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MaxHealth;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MinHealth;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MaxHealth;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MinHealth;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MaxHealth;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MinHealth;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeFieldInfoPtr__beautifySettings;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeMethodInfoPtr_Spawned_Private_Void_0;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003A5D RID: 14941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0;

		// Token: 0x04003A5E RID: 14942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
