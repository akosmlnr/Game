using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B7 RID: 1463
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06007FC8 RID: 32712 RVA: 0x002259A0 File Offset: 0x00223BA0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethDefinition()
		{
			Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr);
			LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "StaticLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "LiquidVolumeColor");
			LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "PourParticlesColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableSolidColor");
			LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, 100679378);
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x00225A48 File Offset: 0x00223C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242003, XrefRangeEnd = 242004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x0003C7C4 File Offset: 0x0003A9C4
		public LiquidMethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x00225A84 File Offset: 0x00223C84
		// (set) Token: 0x06007FCC RID: 32716 RVA: 0x0003C7CD File Offset: 0x0003A9CD
		public unsafe Color StaticLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor)) = value;
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00225AAC File Offset: 0x00223CAC
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x0003C7E8 File Offset: 0x0003A9E8
		public unsafe Color LiquidVolumeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor)) = value;
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x00225AD4 File Offset: 0x00223CD4
		// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x0003C803 File Offset: 0x0003AA03
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x06007FD1 RID: 32721 RVA: 0x00225AFC File Offset: 0x00223CFC
		// (set) Token: 0x06007FD2 RID: 32722 RVA: 0x0003C81E File Offset: 0x0003AA1E
		public unsafe Color CookableLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor)) = value;
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x00225B24 File Offset: 0x00223D24
		// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x0003C839 File Offset: 0x0003AA39
		public unsafe Color CookableSolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor)) = value;
			}
		}

		// Token: 0x040056F0 RID: 22256
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidColor;

		// Token: 0x040056F1 RID: 22257
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolumeColor;

		// Token: 0x040056F2 RID: 22258
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x040056F3 RID: 22259
		private static readonly IntPtr NativeFieldInfoPtr_CookableLiquidColor;

		// Token: 0x040056F4 RID: 22260
		private static readonly IntPtr NativeFieldInfoPtr_CookableSolidColor;

		// Token: 0x040056F5 RID: 22261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
