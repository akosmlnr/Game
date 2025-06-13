using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F1 RID: 1521
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x06008524 RID: 34084 RVA: 0x00238C58 File Offset: 0x00236E58
		// Note: this type is marked as 'beforefieldinit'.
		static SoilDefinition()
		{
			Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SoilDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr);
			SoilDefinition.NativeFieldInfoPtr_SoilQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "SoilQuality");
			SoilDefinition.NativeFieldInfoPtr_DrySoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "DrySoilMat");
			SoilDefinition.NativeFieldInfoPtr_WetSoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "WetSoilMat");
			SoilDefinition.NativeFieldInfoPtr_ParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "ParticleColor");
			SoilDefinition.NativeFieldInfoPtr_Uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "Uses");
			SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, 100680059);
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x00238D00 File Offset: 0x00236F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250770, XrefRangeEnd = 250771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x0003F02F File Offset: 0x0003D22F
		public SoilDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x00238D3C File Offset: 0x00236F3C
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x0003F038 File Offset: 0x0003D238
		public unsafe SoilDefinition.ESoilQuality SoilQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality)) = value;
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x06008529 RID: 34089 RVA: 0x00238D64 File Offset: 0x00236F64
		// (set) Token: 0x0600852A RID: 34090 RVA: 0x0003F053 File Offset: 0x0003D253
		public unsafe Material DrySoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x00238D94 File Offset: 0x00236F94
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x0003F072 File Offset: 0x0003D272
		public unsafe Material WetSoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600852D RID: 34093 RVA: 0x00238DC4 File Offset: 0x00236FC4
		// (set) Token: 0x0600852E RID: 34094 RVA: 0x0003F091 File Offset: 0x0003D291
		public unsafe Color ParticleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor)) = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600852F RID: 34095 RVA: 0x00238DEC File Offset: 0x00236FEC
		// (set) Token: 0x06008530 RID: 34096 RVA: 0x0003F0AC File Offset: 0x0003D2AC
		public unsafe int Uses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses)) = value;
			}
		}

		// Token: 0x04005AA4 RID: 23204
		private static readonly IntPtr NativeFieldInfoPtr_SoilQuality;

		// Token: 0x04005AA5 RID: 23205
		private static readonly IntPtr NativeFieldInfoPtr_DrySoilMat;

		// Token: 0x04005AA6 RID: 23206
		private static readonly IntPtr NativeFieldInfoPtr_WetSoilMat;

		// Token: 0x04005AA7 RID: 23207
		private static readonly IntPtr NativeFieldInfoPtr_ParticleColor;

		// Token: 0x04005AA8 RID: 23208
		private static readonly IntPtr NativeFieldInfoPtr_Uses;

		// Token: 0x04005AA9 RID: 23209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B32 RID: 2866
		[OriginalName("Assembly-CSharp.dll", "", "ESoilQuality")]
		public enum ESoilQuality
		{
			// Token: 0x040092FB RID: 37627
			Basic,
			// Token: 0x040092FC RID: 37628
			Premium
		}
	}
}
